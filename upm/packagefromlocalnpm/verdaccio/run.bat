docker pull verdaccio/verdaccio
docker run -d --rm --name verdaccio -p 4873:4873 verdaccio/verdaccio
npm adduser --registry http://localhost:4873
