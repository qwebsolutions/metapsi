#!/bin/sh

REPO_URL=$(git config --get remote.origin.url)
REPO_BRANCH=$(git branch --show-current)
REPO_COMMIT=$(git rev-parse HEAD)

rm ./nugets -r
version=1.7.0
#version="$(date +"%Y.%m.%d%H%M")"
outputFolder=nugets
echo "Output folder: $outputFolder"
echo "Version: $version"
dotnet pack ../Metapsi.Runtime -o $outputFolder -c Release -p:Version="$version" -p:RepositoryUrl="$REPO_URL" -p:RepositoryBranch="$REPO_BRANCH" -p:RepositoryCommit="$REPO_COMMIT" -p:RepositoryType="git"
dotnet pack ../Metapsi.Module -o $outputFolder -c Release -p:Version="$version" -p:RepositoryUrl="$REPO_URL" -p:RepositoryBranch="$REPO_BRANCH" -p:RepositoryCommit="$REPO_COMMIT" -p:RepositoryType="git"
dotnet pack ../Metapsi.Hyperapp -o $outputFolder -c Release -p:Version="$version" -p:RepositoryUrl="$REPO_URL" -p:RepositoryBranch="$REPO_BRANCH" -p:RepositoryCommit="$REPO_COMMIT" -p:RepositoryType="git"
dotnet pack ../Metapsi.Web -o $outputFolder -c Release -p:Version="$version" -p:RepositoryUrl="$REPO_URL" -p:RepositoryBranch="$REPO_BRANCH" -p:RepositoryCommit="$REPO_COMMIT" -p:RepositoryType="git"
dotnet pack ../Metapsi.JavaScript -o $outputFolder -c Release -p:Version="$version" -p:RepositoryUrl="$REPO_URL" -p:RepositoryBranch="$REPO_BRANCH" -p:RepositoryCommit="$REPO_COMMIT" -p:RepositoryType="git"
dotnet pack ../Metapsi.ChoicesJs -o $outputFolder -c Release -p:Version="$version" -p:RepositoryUrl="$REPO_URL" -p:RepositoryBranch="$REPO_BRANCH" -p:RepositoryCommit="$REPO_COMMIT" -p:RepositoryType="git"
dotnet pack ../Metapsi.Dom -o $outputFolder -c Release -p:Version="$version" -p:RepositoryUrl="$REPO_URL" -p:RepositoryBranch="$REPO_BRANCH" -p:RepositoryCommit="$REPO_COMMIT" -p:RepositoryType="git"
dotnet pack ../Metapsi.Shoelace -o $outputFolder -c Release -p:Version="$version" -p:RepositoryUrl="$REPO_URL" -p:RepositoryBranch="$REPO_BRANCH" -p:RepositoryCommit="$REPO_COMMIT" -p:RepositoryType="git"
dotnet pack ../Metapsi.Heroicons -o $outputFolder -c Release -p:Version="$version" -p:RepositoryUrl="$REPO_URL" -p:RepositoryBranch="$REPO_BRANCH" -p:RepositoryCommit="$REPO_COMMIT" -p:RepositoryType="git"
dotnet pack ../Metapsi.Redis -o $outputFolder -c Release -p:Version="$version" -p:RepositoryUrl="$REPO_URL" -p:RepositoryBranch="$REPO_BRANCH" -p:RepositoryCommit="$REPO_COMMIT" -p:RepositoryType="git"
dotnet pack ../Metapsi.Messaging -o $outputFolder -c Release -p:Version="$version" -p:RepositoryUrl="$REPO_URL" -p:RepositoryBranch="$REPO_BRANCH" -p:RepositoryCommit="$REPO_COMMIT" -p:RepositoryType="git"
dotnet pack ../Metapsi.SQLite -o $outputFolder -c Release -p:Version="$version" -p:RepositoryUrl="$REPO_URL" -p:RepositoryBranch="$REPO_BRANCH" -p:RepositoryCommit="$REPO_COMMIT" -p:RepositoryType="git"
dotnet pack ../Metapsi.Ui -o $outputFolder -c Release -p:Version="$version" -p:RepositoryUrl="$REPO_URL" -p:RepositoryBranch="$REPO_BRANCH" -p:RepositoryCommit="$REPO_COMMIT" -p:RepositoryType="git"
