#!/usr/bin/env bash
set -e

# Environment
BASEPATH="$(pwd)"
OUTPUTS="$BASEPATH/outputs"
mkdir -p "$OUTPUTS"

# SDL
ARGS=( cmake .. -G "Visual Studio 17 2022" -DSDL_SHARED=ON -DSDL_STATIC=OFF )
source "$BASEPATH/.github/scripts/Libraries/SDL.sh"
cp "$INSTALLPATH/bin/SDL3.dll" "$OUTPUTS"

# SDL Image
ARGS=( cmake .. -G "Visual Studio 17 2022" -DBUILD_SHARED_LIBS=ON -DSDL3_DIR="$BASEPATH/SDL/install_output/cmake")
source "$BASEPATH/.github/scripts/Libraries/SDL_Image.sh"
cp "$INSTALLPATH/bin/SDL3_image.dll" "$OUTPUTS"

# SDL Mixer
ARGS=( cmake .. -G "Visual Studio 17 2022" -DBUILD_SHARED_LIBS=ON -DSDL3_DIR="$BASEPATH/SDL/install_output/cmake")
source "$BASEPATH/.github/scripts/Libraries/SDL_Mixer.sh"
cp "$INSTALLPATH/bin/SDL3_mixer.dll" "$OUTPUTS"

# SDL Ttf
ARGS=( cmake .. -G "Visual Studio 17 2022" -DBUILD_SHARED_LIBS=ON -DSDL3_DIR="$BASEPATH/SDL/install_output/cmake")
source "$BASEPATH/.github/scripts/Libraries/SDL_Ttf.sh"
cp "$INSTALLPATH/bin/SDL3_ttf.dll" "$OUTPUTS"