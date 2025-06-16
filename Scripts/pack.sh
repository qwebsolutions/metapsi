#!/bin/sh

if [ -z "$1" ]
then
    echo 'Version not specified'
    exit 1
else
    echo 'Packing version '$1
fi

REPO_URL=$(git config --get remote.origin.url)
REPO_BRANCH=$(git branch --show-current)
REPO_COMMIT=$(git rev-parse HEAD)

rm ./nugets -rf
version=$1
outputFolder=nugets
echo "Output folder: $outputFolder"
echo "Version: $version"
dotnet pack ../Metapsi.Runtime -o $outputFolder -c Release -p:Version="$version" -p:RepositoryUrl="$REPO_URL" -p:RepositoryBranch="$REPO_BRANCH" -p:RepositoryCommit="$REPO_COMMIT" -p:RepositoryType="git"
dotnet pack ../Metapsi.Module -o $outputFolder -c Release -p:Version="$version" -p:RepositoryUrl="$REPO_URL" -p:RepositoryBranch="$REPO_BRANCH" -p:RepositoryCommit="$REPO_COMMIT" -p:RepositoryType="git"
dotnet pack ../Metapsi.Html -o $outputFolder -c Release -p:Version="$version" -p:RepositoryUrl="$REPO_URL" -p:RepositoryBranch="$REPO_BRANCH" -p:RepositoryCommit="$REPO_COMMIT" -p:RepositoryType="git"
dotnet pack ../Metapsi.Web -o $outputFolder -c Release -p:Version="$version" -p:RepositoryUrl="$REPO_URL" -p:RepositoryBranch="$REPO_BRANCH" -p:RepositoryCommit="$REPO_COMMIT" -p:RepositoryType="git"
dotnet pack ../Metapsi.Shoelace -o $outputFolder -c Release -p:Version="$version" -p:RepositoryUrl="$REPO_URL" -p:RepositoryBranch="$REPO_BRANCH" -p:RepositoryCommit="$REPO_COMMIT" -p:RepositoryType="git"
dotnet pack ../Metapsi.Ionic -o $outputFolder -c Release -p:Version="$version" -p:RepositoryUrl="$REPO_URL" -p:RepositoryBranch="$REPO_BRANCH" -p:RepositoryCommit="$REPO_COMMIT" -p:RepositoryType="git"
dotnet pack ../Metapsi.Heroicons -o $outputFolder -c Release -p:Version="$version" -p:RepositoryUrl="$REPO_URL" -p:RepositoryBranch="$REPO_BRANCH" -p:RepositoryCommit="$REPO_COMMIT" -p:RepositoryType="git"
dotnet pack ../Metapsi.Redis -o $outputFolder -c Release -p:Version="$version" -p:RepositoryUrl="$REPO_URL" -p:RepositoryBranch="$REPO_BRANCH" -p:RepositoryCommit="$REPO_COMMIT" -p:RepositoryType="git"
dotnet pack ../Metapsi.Messaging -o $outputFolder -c Release -p:Version="$version" -p:RepositoryUrl="$REPO_URL" -p:RepositoryBranch="$REPO_BRANCH" -p:RepositoryCommit="$REPO_COMMIT" -p:RepositoryType="git"
dotnet pack ../Metapsi.Sqlite -o $outputFolder -c Release -p:Version="$version" -p:RepositoryUrl="$REPO_URL" -p:RepositoryBranch="$REPO_BRANCH" -p:RepositoryCommit="$REPO_COMMIT" -p:RepositoryType="git"
