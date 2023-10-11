#!/bin/bash

source ./publishVars.sh

helpMsg='Parameters are: csproj version target (target is win10-x64 or linux-x64)'

if [ -z "$1" ]
then
      echo 'Project not set. '$helpMsg
	  exit 0
else
	echo 'Project '$1
fi

if [ -z "$2" ]
then
      echo 'Version not set.'$helpMsg
	  exit 0
else
	echo 'Version '$2
fi

if [ -z "$3" ]
then
      echo 'Target not set. '$helpMsg
	  exit 0
else
	echo 'Target '$3
fi

revision=$(git rev-parse HEAD)
echo "$revision"

git tag -a $2 -m 'version '$2
git push origin $2

remoteCommand="cd "$REMOTE_REPO"; git fetch --all --tags; git checkout "$2"; cd PublishScripts; chmod +x publishAlg.sh; ./publishAlg.sh "$1" "$2" "$3";"
echo $remoteCommand

ssh $REMOTE_USER@$REMOTE_MACHINE $remoteCommand