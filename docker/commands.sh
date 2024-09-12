docker --version
docker run hello-world
sudo docker run hello-world
docker ps
sudo usermod -aG docker $alexdejesus
sudo usermod -aG docker alexdejesus
sudo service docker start && sudo systemctl enable docker
sudo systemctl status docker
docker os
docker run hello-world
docker ps -a
docker version
docker pull hello-world
docker images
docker pull ubuntu ubuntu
docker pull --help
docker run ubuntu
docker run -dti ubuntu
docker exec -it bb60 /bin/bash
docker run --name ubuntu ubuntu
docker rm ubuntu
docker rm c20 f5c
docker rm f66 359d
docker stop bb60
docker run --name ubuntu
docker exec -it bb60 /bin/bash --name ubuntu
docker rename frosty_leavitt ubuntu
docker rmi hello-world
docker run -it ubuntu
docker run -dit ubuntu
docker exec -it 9b37 ls
docker rm mystifying_mahavira
docker rm sharp_ritchie
docker stop sharp_ritchie && docker rm 9b37
docker start ubuntu
docker exec -it ubuntu ls
docker exec -it ubuntu touch meu_arquivo.txt
docker cp ubuntu:/meu_arquivo.txt
docker cp ubuntu:/meu_arquivo.txt /.
docker exec -it ubuntu chmod 777 meu_arquivo
docker exec -it ubuntu chmod 777 meu_arquivo.txt
docker exec -it ubuntu ls -a
docker exec -it ubuntu ls -p
sudo docker cp ubuntu:/meu_arquivo.txt /~
sudo docker cp ubuntu:/meu_arquivo.txt /home/alexdejesus
docker run --name test ubuntu
docker rename flamboyant_noether sql_server
docker exec --help
docker exec -it sql_server bash
docker pull mysql
docker run --name mysql -e MYSQL_ROOT_PASSWORD=root -d -p 3306:3306 mysql
docker exec -it mysql bash
docker inspect mysql
