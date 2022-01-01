# Docker Demo Project

## Setup Demo Project
### Clone Repository
```sh
git clone -b main https://github.com/filipe11402/products-core.git
```

### Publish the App in release configuration
```sh
dotnet publish -c release
```
### Create the Docker image
```sh
docker build -t image-name-desired -f Dockerfile
```
### Create Docker image instance(Container)
```sh
docker create -p 6000:80 --name docker-container-image docker-image-name
```
### Run Docker container
```sh
docker container start docker-container-name
```
### Stop Docker container
```sh
docker container stop docker-container-name
```
---
## Documentation
### Dockerfile
- [Here](https://github.com/filipe11402/products-core/blob/main/Dockerfile)
