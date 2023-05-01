.PHONY: all
## Generate sync unit tests, format, lint, and test
all: precommit


.PHONY: build
## Build project
build:
	@dotnet build


.PHONY: clean
## Remove build files
clean:
	@dotnet clean


.PHONY: clean-build
## Build project
clean-build: clean restore build


.PHONY: format
## Format code
format:
	@dotnet format


.PHONY: restore
## Sync dependencies
restore:
	@dotnet restore


.PHONY:
## Run unit and integration tests
test: test-net-framework test-net6

.PHONY: test-net-framework
## Run unit and integration tests against .NET6
test-net-framework: test-net-framework-momento test-net-framework-redis


.PHONY: test-net-framework-momento
## Run unit and integration tests against .NET Framework backed by Momento
test-net-framework-momento:
	@dotnet test -f net461


.PHONY: test-net-framework-redis
## Run unit and integration tests against .NET Framework backed by Redis
test-net-framework-redis:
	@USE_REDIS=1 dotnet test -f net461


.PHONY: test-net6
## Run unit and integration tests against .NET6
test: test-net6-momento test-net6-redis


.PHONY: test-net6-momento
## Run unit and integration tests against .NET 6 backed by Momento
test-net6-momento:
	@dotnet test -f net6.0


.PHONY: test-net6-redis
## Run unit and integration tests against .NET 6 backed by Redis
test-net6-redis:
	@USE_REDIS=1 dotnet test -f net6.0


.PHONY: precommit
## Run clean-build, format, and test as a step before committing.
precommit: clean-build format test


.PHONY: precommit-net6
## Run clean-build, format, and test as a step before committing.
precommit-net6: clean-build format test-net6


# See <https://gist.github.com/klmr/575726c7e05d8780505a> for explanation.
.PHONY: help
help:
	@echo "$$(tput bold)Available rules:$$(tput sgr0)";echo;sed -ne"/^## /{h;s/.*//;:d" -e"H;n;s/^## //;td" -e"s/:.*//;G;s/\\n## /---/;s/\\n/ /g;p;}" ${MAKEFILE_LIST}|LC_ALL='C' sort -f|awk -F --- -v n=$$(tput cols) -v i=19 -v a="$$(tput setaf 6)" -v z="$$(tput sgr0)" '{printf"%s%*s%s ",a,-i,$$1,z;m=split($$2,w," ");l=n-i;for(j=1;j<=m;j++){l-=length(w[j])+1;if(l<= 0){l=n-i-length(w[j])-1;printf"\n%*s ",-i," ";}printf"%s ",w[j];}printf"\n";}'|more $(shell test $(shell uname) == Darwin && echo '-Xr')
