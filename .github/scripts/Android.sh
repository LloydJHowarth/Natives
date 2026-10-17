#!/usr/bin/env bash
set -e

# Environment
BASEPATH="$(pwd)"
OUTPUTS="$BASEPATH/outputs"
mkdir -p "$OUTPUTS"

# Android
ANDROID_TARGET="21"
ANDROID_COMPILE="36"
NDK_VERSION="29.0.13846066"
ANDROID_SDK="$ANDROID_HOME"
ANDROID_NDK="$ANDROID_NDK_HOME/build/cmake/android.toolchain.cmake"
export PATH="$ANDROID_HOME/cmdline-tools/latest/bin:$ANDROID_HOME/tools/bin:$JAVA_HOME/bin:$PATH"
yes | sdkmanager --install "platforms;android-$ANDROID_TARGET"
yes | sdkmanager --install "platforms;android-$ANDROID_COMPILE"
yes | sdkmanager --install "ndk;$NDK_VERSION"
yes | sdkmanager --install "platform-tools"

# SDL
ARGS=( cmake .. -G "Ninja" -DSDL_SHARED=ON -DSDL_STATIC=OFF -DSDL_ANDROID_JAR=OFF -DCMAKE_TOOLCHAIN_FILE="$ANDROID_NDK" -DANDROID_PLATFORM=android-$ANDROID_TARGET -DANDROID_ABI="$CPU" -DCMAKE_SHARED_LINKER_FLAGS="-Wl,-z,max-page-size=16384" -DCMAKE_EXE_LINKER_FLAGS="-Wl,-z,max-page-size=16384")
source "$BASEPATH/.github/scripts/Libraries/SDL.sh"
cp "$INSTALLPATH/lib/libSDL3.so" "$OUTPUTS"

# SDL_image
ARGS=( cmake .. -G "Ninja" -DBUILD_SHARED_LIBS=ON -DCMAKE_TOOLCHAIN_FILE="$ANDROID_NDK" -DANDROID_PLATFORM=android-$ANDROID_TARGET -DANDROID_ABI="$CPU" -DCMAKE_SHARED_LINKER_FLAGS="-Wl,-z,max-page-size=16384" -DCMAKE_EXE_LINKER_FLAGS="-Wl,-z,max-page-size=16384" -DSDL3_DIR="$BASEPATH/SDL/install_output/lib/cmake/SDL3")
source "$BASEPATH/.github/scripts/Libraries/SDL_image.sh"
cp "$INSTALLPATH/lib/libSDL3_image.so" "$OUTPUTS"

# SDL_mixer
ARGS=( cmake .. -G "Ninja" -DBUILD_SHARED_LIBS=ON -DCMAKE_TOOLCHAIN_FILE="$ANDROID_NDK" -DANDROID_PLATFORM=android-$ANDROID_TARGET -DANDROID_ABI="$CPU" -DCMAKE_SHARED_LINKER_FLAGS="-Wl,-z,max-page-size=16384" -DCMAKE_EXE_LINKER_FLAGS="-Wl,-z,max-page-size=16384" -DSDL3_DIR="$BASEPATH/SDL/install_output/lib/cmake/SDL3")
source "$BASEPATH/.github/scripts/Libraries/SDL_mixer.sh"
cp "$INSTALLPATH/lib/libSDL3_mixer.so" "$OUTPUTS"

# SDL_ttf
ARGS=( cmake .. -G "Ninja" -DBUILD_SHARED_LIBS=ON -DCMAKE_TOOLCHAIN_FILE="$ANDROID_NDK" -DANDROID_PLATFORM=android-$ANDROID_TARGET -DANDROID_ABI="$CPU" -DCMAKE_SHARED_LINKER_FLAGS="-Wl,-z,max-page-size=16384" -DCMAKE_EXE_LINKER_FLAGS="-Wl,-z,max-page-size=16384" -DSDL3_DIR="$BASEPATH/SDL/install_output/lib/cmake/SDL3")
source "$BASEPATH/.github/scripts/Libraries/SDL_ttf.sh"
cp "$INSTALLPATH/lib/libSDL3_ttf.so" "$OUTPUTS"

# SDL_activity
ARGS=()
source "$BASEPATH/.github/scripts/Libraries/SDL_activity.sh"
cp "$INSTALLPATH/SDLActivity.jar" "$OUTPUTS"