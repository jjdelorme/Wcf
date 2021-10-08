# README
Simple WCF example with client and server implementation.  Dockerfile is included to run in a container.  WcfService (server) expects an environment variable `PORT` to determine which port to listen on.

## Build the container
```bash
docker build -t wcfservice:v1 -f Dockerfile .
```

## Run the container locally

To listen on port 7665 and expose.
```
bash
docker run -it -p 7665:7665 -e PORT=7665 wcfservice:v1
```
