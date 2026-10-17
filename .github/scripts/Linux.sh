#!/usr/bin/env bash
set -e

# Environment
BASEPATH="$(pwd)"
OUTPUTS="$BASEPATH/outputs"
mkdir -p "$OUTPUTS"
sudo apt-get update
sudo apt-get install -y \
  build-essential git make pkg-config cmake ninja-build \
  libx11-dev libxext-dev libxrandr-dev libxcursor-dev libxi-dev libxinerama-dev \
  libxfixes-dev libxss-dev libxtst-dev libxkbcommon-dev libdrm-dev libgbm-dev \
  libgl1-mesa-dev libgles2-mesa-dev libegl1-mesa-dev \
  libasound2-dev libpulse-dev libaudio-dev libfribidi-dev libjack-dev libsndio-dev \
  libdbus-1-dev libibus-1.0-dev libudev-dev libpipewire-0.3-dev libwayland-dev \
  libdecor-0-dev liburing-dev

# SDL
ARGS=( cmake .. -G "Ninja" -DSDL_SHARED=ON -DSDL_STATIC=OFF )
source "$BASEPATH/.github/scripts/Libraries/SDL.sh"
cp "$INSTALLPATH/lib/libSDL3.so" "$OUTPUTS"

# SDL_image
ARGS=( cmake .. -G "Ninja" -DBUILD_SHARED_LIBS=ON -DSDL3_DIR="$BASEPATH/SDL/install_output/lib/cmake/SDL3")
source "$BASEPATH/.github/scripts/Libraries/SDL_image.sh"
cp "$INSTALLPATH/lib/libSDL3_image.so" "$OUTPUTS"

# SDL_mixer
ARGS=( cmake .. -G "Ninja" -DBUILD_SHARED_LIBS=ON -DSDL3_DIR="$BASEPATH/SDL/install_output/lib/cmake/SDL3")
source "$BASEPATH/.github/scripts/Libraries/SDL_mixer.sh"
cp "$INSTALLPATH/lib/libSDL3_mixer.so" "$OUTPUTS"

# SDL_ttf
ARGS=( cmake .. -G "Ninja" -DBUILD_SHARED_LIBS=ON -DSDL3_DIR="$BASEPATH/SDL/install_output/lib/cmake/SDL3")
source "$BASEPATH/.github/scripts/Libraries/SDL_ttf.sh"
cp "$INSTALLPATH/lib/libSDL3_ttf.so" "$OUTPUTS"