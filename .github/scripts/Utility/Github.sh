#!/usr/bin/env bash
set +e

Github()
{
    local NAME="$1"
    local URL="${2:-}"
    local COMMIT="${3:-}"
    local TARGETDIRECTORY="$NAME"

    if [ ! -d "$TARGETDIRECTORY" ]; then
      
        if [ -n "$URL" ]; then
          
            echo "$NAME $COMMIT [Downloading from $URL]"
            git clone "$URL" "$TARGETDIRECTORY"

            if [ -n "$COMMIT" ]; then
                git checkout "$COMMIT"
            fi

            git submodule update --init --recursive
        else
            echo "No valid url provided for $NAME"
            return 1
        fi
    else
        echo "$NAME $COMMIT [Already Installed]"
    fi
}
