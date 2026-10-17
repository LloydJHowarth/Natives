#!/usr/bin/env bash
set -e

# Environment
BASEPATH="$(pwd)"
OUTPUTS="$BASEPATH/outputs"
mkdir -p "$OUTPUTS"

# SDL
ARGS=( cmake .. -A "$CPU" -G "Visual Studio 17 2022" -DSDL_SHARED=ON -DSDL_STATIC=OFF )
source "$BASEPATH/.github/scripts/Libraries/SDL.sh"
cp "$INSTALLPATH/bin/SDL3.dll" "$OUTPUTS"

# SDL_image
ARGS=( cmake .. -A "$CPU" -G "Visual Studio 17 2022" -DBUILD_SHARED_LIBS=ON -DSDL3_DIR="$BASEPATH/SDL/install_output/cmake")
source "$BASEPATH/.github/scripts/Libraries/SDL_image.sh"
cp "$INSTALLPATH/bin/SDL3_image.dll" "$OUTPUTS"

# SDL_mixer
ARGS=( cmake .. -A "$CPU" -G "Visual Studio 17 2022" -DBUILD_SHARED_LIBS=ON -DSDL3_DIR="$BASEPATH/SDL/install_output/cmake")
source "$BASEPATH/.github/scripts/Libraries/SDL_mixer.sh"
cp "$INSTALLPATH/bin/SDL3_mixer.dll" "$OUTPUTS"

# SDL_ttf
ARGS=( cmake .. -A "$CPU" -G "Visual Studio 17 2022" -DBUILD_SHARED_LIBS=ON -DSDL3_DIR="$BASEPATH/SDL/install_output/cmake")
source "$BASEPATH/.github/scripts/Libraries/SDL_ttf.sh"
cp "$INSTALLPATH/bin/SDL3_ttf.dll" "$OUTPUTS"