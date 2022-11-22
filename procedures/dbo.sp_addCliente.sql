create procedure sp_addCliente

	 @CLI_NOME varchar(50)
	,@CLI_CPF varchar(50)
	,@CLI_RG varchar(50) 
	,@CLI_SEXO bit 
	,@CLI_DATA_NASC date
	,@CLI_PROFISSAO varchar(50)
	,@CLI_TELEFONE varchar(50)
	,@CLI_CELULAR varchar(50)
	,@CLI_EMAIL varchar(50)
	,@CLI_LOGRADOURO varchar(50)
	,@CLI_MUNICIPIO varchar(50)
	,@CLI_BAIRRO varchar(50)
	,@CLI_NUMERO varchar(50)
	,@CLI_COMPLEMENTO varchar(50)
	,@CLI_CEP varchar(50)
	,@CLI_CNPJ varchar(50)

as 

insert into Clientes 
(
	CLI_NOME, 
	CLI_CPF, 
	CLI_RG, 
	CLI_SEXO, 
	CLI_DATA_NASC, 
	CLI_DATA_CADASTRO,
	CLI_PROFISSAO, 
	CLI_TELEFONE, 
	CLI_CELULAR, 
	CLI_EMAIL, 
	CLI_LOGRADOURO, 
	CLI_MUNICIPIO,
	CLI_BAIRRO, 
	CLI_NUMERO, 
	CLI_COMPLEMENTO, 
	CLI_CEP,
	CLI_CNPJ
) 
values 
(
	@CLI_NOME, 
	@CLI_CPF, 
	@CLI_RG, 
	@CLI_SEXO, 
	@CLI_DATA_NASC, 
	getdate(),
	@CLI_PROFISSAO, 
	@CLI_TELEFONE, 
	@CLI_CELULAR, 
	@CLI_EMAIL, 
	@CLI_LOGRADOURO, 
	@CLI_MUNICIPIO,
	@CLI_BAIRRO, 
	@CLI_NUMERO, 
	@CLI_COMPLEMENTO, 
	@CLI_CEP,
	@CLI_CNPJ
)