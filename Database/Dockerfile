FROM mysql:8.0.22
ARG DEBIAN_FRONTEND=noninteractive

ENV MYSQL_ROOT_PASSWORD=Hoai20011109NguyenNgoc
ENV MYSQL_USER=hoainn
ENV MYSQL_PASSWORD=Hoai20011109NguyenNgoc
ENV MYSQL_DATABASE=shoeslover

COPY shoeslover.sql  /docker-entrypoint-initdb.d
