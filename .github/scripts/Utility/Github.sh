#!/usr/bin/env bash
set -e

Github()
{
    local NAME="$1"
    local REPO="${2:-}"
    local VERSION="${3:-}"
    local TARGETDIRECTORY="$NAME"

    if [ ! -d "$TARGETDIRECTORY" ]; then
      
        if [ -n "$REPO" ]; then
          
            echo "$NAME $VERSION [Downloading from $REPO]"
            git clone "$REPO" "$TARGETDIRECTORY"

            if [ -n "$VERSION" ]; then
                git checkout "$VERSION"
            fi

            git submodule update --init --recursive
        else
            echo "No valid url provided for $NAME"
            return 1
        fi
    else
        echo "$NAME $VERSION [Already Installed]"
    fi
}