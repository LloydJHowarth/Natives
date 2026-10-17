#!/usr/bin/env bash
set +e

if [[ ! -d "$BASEPATH/SDL_ttf" ]]; then
    git clone --recurse-submodules https://github.com/libsdl-org/SDL_ttf.git "$BASEPATH/SDL_ttf"
fi

# Environment
INSTALLPATH="$BASEPATH/SDL_ttf/install_output"
BUILDPATH="$BASEPATH/SDL_ttf/build_output"
mkdir -p "$BUILDPATH"
mkdir -p "$INSTALLPATH"
cd "$BUILDPATH"

# SDL_ttf
"${ARGS[@]}" \
  -DSDLTTF_SAMPLES=OFF \
  -DSDLTTF_HARFBUZZ=OFF \
  -DSDLTTF_PLUTOSVG=OFF \
  -DSDLTTF_VENDORED=ON \
  -DCMAKE_BUILD_TYPE=Release \
  -DCMAKE_POLICY_VERSION_MINIMUM=3.5 \
  -DCMAKE_INSTALL_PREFIX="$INSTALLPATH"

cmake --build . --config Release
cmake --install . --config Release

echo "Output files...."
find "$INSTALLPATH"