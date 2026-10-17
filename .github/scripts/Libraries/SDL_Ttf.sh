#!/usr/bin/env bash
set +e

# SDL_image
BASEPATH="$(pwd)"

if [[ ! -d "$BASEPATH/SDL_image" ]]; then
    git clone --recurse-submodules https://github.com/libsdl-org/SDL_image.git "$BASEPATH/SDL_image"
fi

# Environment
INSTALLPATH="$BASEPATH/SDL_image/install_output"
BUILDPATH="$BASEPATH/SDL_image/build_ouput"
mkdir -p "$BUILDPATH"
mkdir -p "$INSTALLPATH"
cd "$BUILDPATH"

# SDL_image
"${ARGS[@]}" \
  -DSDLTTF_VENDORED=ON \
  -DSDLTTF_HARFBUZZ=OFF \
  -DSDLTTF_PLUTOSVG=OFF \
  -DSDLTTF_SAMPLES=OFF \
  -DSDLTTF_INSTALL=OFF \
  -DCMAKE_BUILD_TYPE=Release \
  -DCMAKE_POLICY_VERSION_MINIMUM=3.5 \
  -DCMAKE_INSTALL_PREFIX="$INSTALLPATH"

cmake --build . --config Release
cmake --install . --config Release

echo "Output files...."
find "$INSTALLPATH"