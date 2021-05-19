#!/bin/bash
set -e

psql -c "DROP DATABASE IF EXISTS test"

psql -c "CREATE DATABASE test"

psql -d test -f /usr/local/src/schema.sql
