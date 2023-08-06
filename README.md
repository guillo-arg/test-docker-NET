# .NET core 3.1 con docker

Este proyecto sirve para crear una imagen y levantar contenedores con docker compose para utilizar .NET core 3.1 con Mysql 8.1 y tener acceso a la base de datos con phpMyAdmin.


# Como iniciar

En la raiz del proyecto, donde se encuentra el archivo Dockerfile se debe correr el comando para crear la imagen:

    docker build --tag app-cliente .

Luego en el mismo lugar se debe correr el comando para levantar el docker compose:

    docker compose up -d

Para apagar los contenedores se deben correr el siguiente comando:

    docker compose down

Cuando se hace cambios en el codigo de .NET core 3.1 se debe reconstruir la imagen antes de levantar los contenedores.


# Como probar
Podemos acceder a la api y a la base de datos por phpmyadmin

## API

Para probar la api se puede acceder al siguiente enlace que trae los clientes cargados en la base de datos:

http://localhost:5001/clientes


## PHPMYADMIN
Para acceder a la base de datos por phpMyAdmin se puede acceder al enlace;

http://localhost:8080/

Con los siguientes parametros:
|Parametro|Valor  |
|--|--|
|servidor  | db |
|usuario  | root |
|contraseña| 123456 |

La base de datos y la tabla que trae los datos se llaman **Clientes**
