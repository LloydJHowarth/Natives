#!/usr/bin/env bash
set +e

# Setup
BASEPATH="$(pwd)"
OUTPUTS="$BASEPATH/outputs"
mkdir -p "$OUTPUTS"

# Github
source "$BASEPATH/.github/scripts/Utility/Github.sh"
Github "$BASEPATH/SDL" "https://github.com/libsdl-org/SDL.git" ""
Github "$BASEPATH/SDL_ttf" "https://github.com/libsdl-org/SDL_ttf.git" ""

# Files
FILES=(
  SDL_textengine
  SDL_ttf
)


# Generate
for file in "${FILES[@]}"; do
  
  ARGS=(
    -p TTF_
    -m TTF
    -l SDL3_ttf
    -n Toolkit.SDL3
    -c file=single
    
    --remap char=byte
    --remap Sint64=long
    --remap Uint64=ulong
    --remap void*=IntPtr
    --remap nuint=UIntPtr
    --remap bool=SDL_Bool

    --generate macro-bindings
    --generate fnptr-codegen=false
    --generate funcs-with-body=false
    --with-access-specifier *=internal
  )
  
  echo "Generating $file.h"
  ClangSharpPInvokeGenerator.cmd "${ARGS[@]}" -I "$BASEPATH/SDL/include" -I "$BASEPATH/SDL_ttf/include" -f "$BASEPATH/SDL_ttf/include/SDL3_ttf/$file.h" -o "$OUTPUTS/$file.gen.cs" || true
  
done


# Post processing
find "$OUTPUTS" -type f -name "*.cs" -print0 | while IFS= read -r -d '' file; do

  # Info
  echo "Post processing $file"

  # Remove
  sed -i -E '/\[return: NativeTypeName\("[^"]*"\)\]/d' "$file"
  sed -i -E 's/\[NativeTypeName\("[^"]*"\)\] //g' "$file"
  sed -i -E '/\[NativeTypeName.*\]/d' "$file"
  sed -i -E 's/\, __arglist//g' "$file"

  # Rebuild
  sed -i -E 's/\bpublic\b/private/g' "$file"
  sed -i -E 's/\bprivate const\b/public const/g' "$file"
  sed -i -E 's/\bprivate partial\b/public partial/g' "$file"
  sed -i -E 's/\bprivate static readonly\b/public static readonly/g' "$file"
  sed -E -i 's/(static extern [^ ]+ )([A-Za-z_][A-Za-z0-9_]*)\(/\1iTTF_\2(/g' "$file"
  sed -i -E 's/private static ReadOnlySpan<byte> ([A-Za-z0-9_]+) => "([^"]*)"u8;/public static string \1 => "\2";/' "$file"

done