
docker build -t wcfservice:v1 -f Dockerfile .
docker run -it -p 7665:7665 -e PORT=7665 wcfservice:v1