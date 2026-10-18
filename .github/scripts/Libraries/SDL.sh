#!/usr/bin/env bash
set +e

# Github
source "$BASEPATH/.github/scripts/Utility/Github.sh"
Github "$BASEPATH/SDL" "https://github.com/libsdl-org/SDL.git" ""

# Environment
INSTALLPATH="$BASEPATH/SDL/install_output"
BUILDPATH="$BASEPATH/SDL/build_output"
mkdir -p "$BUILDPATH"
mkdir -p "$INSTALLPATH"
cd "$BUILDPATH"

# SDL
"${ARGS[@]}" \
  -DSDL_INSTALL=ON \
  -DSDL_TEST_LIBRARY=OFF \
  -DCMAKE_BUILD_TYPE=MinSizeRel \
  -DCMAKE_POLICY_VERSION_MINIMUM=3.5 \
  -DCMAKE_INSTALL_PREFIX="$INSTALLPATH"

cmake --build . --config MinSizeRel
cmake --install . --config MinSizeRel

echo "Output files...."
find "$INSTALLPATH"