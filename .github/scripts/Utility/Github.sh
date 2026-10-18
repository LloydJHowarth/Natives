#!/usr/bin/env bash
set +e

Github()
{
    local NAME="$1"
    local URL="${2:-}"
    local COMMIT="${3:-}"

    if [ ! -d "$NAME/.git" ]; then

        if [ -n "$URL" ]; then

            echo "$NAME ${COMMIT:-HEAD} [Downloading from $URL]"

            mkdir -p "$(dirname "$NAME")" || return 1

            git clone "$URL" "$NAME" || return 1

            cd "$NAME" || return 1

            if [ -n "$COMMIT" ]; then
                git checkout "$COMMIT" || return 1
            fi

            git submodule update --init --recursive || return 1

        else
            echo "No valid url provided for $NAME" >&2
            return 1
        fi

    else
        echo "$NAME ${COMMIT:-HEAD} [Already Installed]"
    fi
}
