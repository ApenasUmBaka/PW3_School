
CREATE TABLE `projeto_final`.`OutraFormacoes` (
`idOutrasFormacoes` INT NOT NULL AUTO_INCREMENT,
`idusuario` INT NOT NULL,
`inicio` DATE NULL,
`fim` DATE NULL,
`descricao` VARCHAR(45) NULL,
PRIMARY KEY (`idOutrasFormacoes`),
INDEX `idUser_idx` (`idusuario` ASC),
CONSTRAINT `idUser`
FOREIGN KEY (`idusuario`)
REFERENCES `projeto_final`.`usuario` (`idusuario`)
ON DELETE NO ACTION
ON UPDATE NO ACTION);