#!/usr/bin/env bash
set +e

# Github
source "$BASEPATH/.github/scripts/Utility/Github.sh"
Github "$BASEPATH/SDL_ttf" "https://github.com/libsdl-org/SDL_ttf.git" "1abbd07aeda8da762d044dda6c247588e2ef9fc1"

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
  -DCMAKE_BUILD_TYPE=MinSizeRel \
  -DCMAKE_POLICY_VERSION_MINIMUM=3.5 \
  -DCMAKE_INSTALL_PREFIX="$INSTALLPATH"

cmake --build . --config MinSizeRel
cmake --install . --config MinSizeRel

echo "Output files...."
find "$INSTALLPATH"