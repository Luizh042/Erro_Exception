#!/bin/bash
proj_name="EME"
proj_tests="${proj_name}.Tests"
cd "$proj_name"
dotnet run
cd ..