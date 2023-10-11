#!/bin/bash

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

prj=$(dotnet run --project ./GetProjectName/GetProjectName.csproj $1)
echo "$prj"

revision=$(git rev-parse HEAD)
echo "$revision"

zipPath=$prj.$revision.zip
rm -r publish
rm *.zip
dotnet publish $1 -c Release -r $3 -o ./publish
7z a $zipPath ./publish/*

fProject='project='$prj
fFile='binaries=@'$zipPath
fVersion='version='$2
fRevision='revision='$revision
fTarget='target='$3

curl -F $fFile -F $fProject -F $fVersion -F $fRevision -F $fTarget http://s2020:5011/UploadBinaries


echo curl -F $fFile -F $fProject -F $fVersion -F $fRevision -F $fTarget http://localhost:5011/UploadBinaries > push_local.bat