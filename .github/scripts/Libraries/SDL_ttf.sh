#!/usr/bin/env bash
set +e

COMMIT="1abbd07aeda8da762d044dda6c247588e2ef9fc1"

if [[ ! -d "$BASEPATH/SDL_ttf" ]]; then
    git clone --recurse-submodules https://github.com/libsdl-org/SDL_image.git "$BASEPATH/SDL_ttf"
fi

if [[ -n "$COMMIT" ]]; then
    git -C "$BASEPATH/SDL_ttf" fetch origin
    git -C "$BASEPATH/SDL_ttf" checkout "$COMMIT"
    git -C "$BASEPATH/SDL_ttf" submodule update --init --recursive
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