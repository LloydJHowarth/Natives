#!/usr/bin/env bash
set +e

if [[ ! -d "$BASEPATH/SDL_image" ]]; then
    git clone --recurse-submodules https://github.com/libsdl-org/SDL_image.git "$BASEPATH/SDL_image"
fi

# Environment
INSTALLPATH="$BASEPATH/SDL_image/install_output"
BUILDPATH="$BASEPATH/SDL_image/build_output"
mkdir -p "$BUILDPATH"
mkdir -p "$INSTALLPATH"
cd "$BUILDPATH"

# SDL_image
"${ARGS[@]}" \
  -DSDLIMAGE_BMP=ON \
  -DSDLIMAGE_JPG=ON \
  -DSDLIMAGE_PNG=ON \
  -DSDLIMAGE_WEBP=OFF \
  -DSDLIMAGE_AVIF=OFF \
  -DSDLIMAGE_GIF=OFF \
  -DSDLIMAGE_JXL=OFF \
  -DSDLIMAGE_LBM=OFF \
  -DSDLIMAGE_PCX=OFF \
  -DSDLIMAGE_PNM=OFF \
  -DSDLIMAGE_QOI=OFF \
  -DSDLIMAGE_SVG=OFF \
  -DSDLIMAGE_TGA=OFF \
  -DSDLIMAGE_TIF=OFF \
  -DSDLIMAGE_XCF=OFF \
  -DSDLIMAGE_XPM=OFF \
  -DSDLIMAGE_XV=OFF \
  -DSDLIMAGE_ANI=OFF \
  -DSDLIMAGE_TESTS=OFF \
  -DSDLIMAGE_VENDORED=ON \
  -DSDLIMAGE_PNG_LIBPNG=OFF \
  -DSDLIMAGE_DEPS_SHARED=OFF \
  -DCMAKE_BUILD_TYPE=Release \
  -DCMAKE_POLICY_VERSION_MINIMUM=3.5 \
  -DCMAKE_INSTALL_PREFIX="$INSTALLPATH"

cmake --build . --config Release
cmake --install . --config Release

echo "Output files...."
find "$INSTALLPATH"