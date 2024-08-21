USE "DataBase";/*indica qual Data Base usar. Uso de aspas para indicar nome*/
/*Padr�o de escrita query com palavras reservadas em MAISCULO*/

--SELECT * FROM "Clientes" ORDER BY Nome, Sobrenome DESC; /*ASC == crescente - DESC == descrescente. Por padr�o ORDER BY come�a com o ASC*/

--SELECT Email FROM Clientes; --selecionando somente colunas especificas

--sele��o com busca - WHERE
--SELECT * FROM Clientes WHERE Nome = 'Adam' AND Sobrenome = 'Reynolds' ORDER BY Nome; 
--SELECT * FROM Clientes WHERE Nome = 'Adam' OR Sobrenome = 'Reynolds' ORDER BY Nome;

/*seleciona nomes que come�am com a letra 'A'
'A%' - come�a com 'A' e o resto n�o importa
'%A' - termina com 'A' e o resto n�o importa
'%A%' - possui 'A' no meio e o resto n�o importa
*/
--SELECT * FROM Clientes WHERE Nome LIKE '%a%' 

/* inserindo novos dados na tabela.
INSERT INTO Clientes (Nome, Sobrenome, Email, AceitaComunicados, DataCadastro) -- ordem das colunas. Caso n�o seja indicado as colunas deve ser feita a inser��o na ordem em que as colunas est�o salvas na tabela
VALUES ('Alex', ' de Jesus', 'mail@mail.com', 0, GETDATE()) -- valores que ser�o inseridos. GETDATE retorna a data atual em que a query foi executada
*/
--SELECT * FROM Clientes WHERE Nome = 'Alex';

/* Atualiza na tabela Clientes o Email e Nome da linha com Id == 1001
Usar UPDATE sempre com WHERE!
UPDATE Clientes
SET Email = 'Email.mail@mail.com',
	Nome = 'Lexus'
WHERE Id = 1001
SELECT * FROM Clientes WHERE Nome = 'Alex';
*/
/*
BEGIN TRAN --checkpoint, um ponto de onde posso voltar 
ROLLBACK --voltar ao ultimo checkpoint
*/

--Deletar da tabela Cliente a linha que possui Id == 1001
--DELETE Clientes WHERE Id = 1001


/*Built-in Functions : fun��es prontas que auxiliam na manipula��o*/
/*
SELECT COUNT(*) QTD_Produtos FROM Produtos
SELECT COUNT(*) QTD_Produtos FROM Produtos WHERE Tamanho = 'm' --conta a linha da tabela Produtos que possuem Tamanho == m
*/

--SELECT SUM(Preco) Total_Preco FROM Produtos WHERE Tamanho = 'm' --soma os valores da coluna Preco onde Tamanho == m

/*
SELECT MAX(Preco) 'Max' FROM Produtos -- valor maximo, mais alto de Preco
SELECT MIN(Preco) 'Min' FROM Produtos -- valor minimo, mais baixo de Preco
SELECT AVG(Preco) 'Media' FROM Produtos -- m�dia dos valores de Preco
*/

--concatena��o de caracteres
--SELECT Nome + ' <> ' + Cor 'Nome-Cor' FROM Produtos

/*
--transforma em MAISCULO
SELECT Nome, UPPER(Nome) 'Maisculo' FROM Produtos

--transforma em minisculo
SELECT Nome, LOWER(Nome) 'Minisculo' FROM Produtos
*/

--inserindo uma nova coluna
--ALTER TABLE Produtos ADD DataCadastro DATETIME2

--deletando uma coluna
--ALTER TABLE Produtos DROP COLUMN DataCadastro DATETIME2

--a nova coluna est� vazia, � atualizada para todas as linhas nessa coluna terem a data atual
--UPDATE Produtos SET DataCadastro = GETDATE()
--SELECT * FROM Produtos

--formata a data
--SELECT FORMAT(DataCadastro, 'dd/MM/yyyy') Data FROM Produtos 
/*
--conta as linhas que s�o agrupados pela coluna Tamanho onde seja valor diferente de '' e em ordem descrescente
SELECT COUNT(*) Quantidade, Tamanho
FROM Produtos 
WHERE Tamanho <> '' --tamb�m pode ser usado != para operador diferente
GROUP BY Tamanho 
ORDER BY Quantidade DESC
*/
/*
--criando uma tabela e adicionado a ela uma chave estrangeira (Foreign Key)
CREATE TABLE Enderecos (
	Id int PRIMARY KEY IDENTITY(1,1) NOT NULL,--IDENTITY(1,1): auto-incrementa, sendo o primeiro paramentro o numero que come�a e o segundo o valor em que � incrementado, no caso come�a no 1 e incremente de 1 em 1
	IdClientes int NULL,
	Rua varchar(255) NULL,
	Bairro varchar(255) NULL,
	Cidade varchar(255) NULL,
	Estado char(2) NULL,

	CONSTRAINT FK_Enderecos_Clientes FOREIGN KEY(IdClientes) REFERENCES Clientes(Id)
)*/
/*
--INSERT INTO Enderecos VALUES (1001,'Rua Teste', 'Bairro teste', 'Cidade teste', 'SP')

SELECT * FROM Clientes WHERE Id = 1001
SELECT * FROM Enderecos WHERE IdClientes = 1001
*/

--junta selects diferentes em um s�
SELECT 
	Clientes.Nome,
	Clientes.Sobrenome ,
	Clientes.Email,
	Enderecos.Rua ,
	Enderecos.Bairro,
	Enderecos.Cidade,
	Enderecos.Estado
FROM Clientes
INNER JOIN Enderecos ON Clientes.Id = Enderecos.IdClientes WHERE Clientes.Id = 1001


