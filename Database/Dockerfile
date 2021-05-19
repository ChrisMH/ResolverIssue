FROM postgres:12

RUN apt-get update
RUN apt-get install -y dos2unix

# Database initialization scripts
COPY *.sql /usr/local/src/
RUN dos2unix /usr/local/src/*.sql

COPY init.sh /docker-entrypoint-initdb.d/01.sh
RUN dos2unix /docker-entrypoint-initdb.d/01.sh
RUN chmod +x /docker-entrypoint-initdb.d/01.sh

# Clean up installed packages that are no longer needed
RUN apt-get --purge remove -y dos2unix
RUN rm -rf /var/lib/apt/lists/*

# CMD tail -f /dev/null
