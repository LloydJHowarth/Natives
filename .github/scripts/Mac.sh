#!/usr/bin/env bash
set -e

# Environment
BASEPATH="$(pwd)"
OUTPUTS="$BASEPATH/outputs"
mkdir -p "$OUTPUTS"

# SDL
ARGS=( cmake .. -G "Ninja" -DSDL_SHARED=ON -DSDL_STATIC=OFF -DCMAKE_OSX_ARCHITECTURES=$CPU -DCMAKE_OSX_DEPLOYMENT_TARGET=10.13 )
source "$BASEPATH/.github/scripts/Libraries/SDL.sh"
cp "$INSTALLPATH/lib/libSDL3.dylib" "$OUTPUTS"

# SDL_image
ARGS=( cmake .. -G "Ninja" -DBUILD_SHARED_LIBS=ON -DSDL3_DIR="$BASEPATH/SDL/install_output/lib/cmake/SDL3")
source "$BASEPATH/.github/scripts/Libraries/SDL_image.sh"
cp "$INSTALLPATH/lib/libSDL3_image.dylib" "$OUTPUTS"

# SDL_mixer
ARGS=( cmake .. -G "Ninja" -DBUILD_SHARED_LIBS=ON -DSDL3_DIR="$BASEPATH/SDL/install_output/lib/cmake/SDL3")
source "$BASEPATH/.github/scripts/Libraries/SDL_mixer.sh"
cp "$INSTALLPATH/lib/libSDL3_mixer.dylib" "$OUTPUTS"

# SDL_ttf
ARGS=( cmake .. -G "Ninja" -DBUILD_SHARED_LIBS=ON -DSDL3_DIR="$BASEPATH/SDL/install_output/lib/cmake/SDL3")
source "$BASEPATH/.github/scripts/Libraries/SDL_ttf.sh"
cp "$INSTALLPATH/lib/libSDL3_ttf.dylib" "$OUTPUTS"