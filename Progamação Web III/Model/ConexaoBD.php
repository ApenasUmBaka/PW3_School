<?php

class ConexaoBD{
    private $serverNamer = "localhost";
    private $userNamer = "root";
    private $password = "usbw";
    private $dbName = "projeto_final";
}

public function conectar()
{
    $conn = new mysqli($this->serverName, $this->userName, $this->password, $this->dbName);
    return $conn;
}

?>