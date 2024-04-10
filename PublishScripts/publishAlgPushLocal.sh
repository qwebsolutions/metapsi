#!/bin/bash

source ./publishAlg.sh

$curlCmd -F $fFile -F $fProject -F $fVersion -F $fRevision -F $fTarget http://localhost:5011/UploadBinaries

rm $zipPath