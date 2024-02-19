#!/bin/sh

set -e

currentVersion=$(<local.version.txt)

./pack.sh $currentVersion