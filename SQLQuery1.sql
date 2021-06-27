create table Produto(
	IdProduto		integer			identity(1,1),
	Nome			nvarchar(150)	unique not null,
	Preco			decimal(6,2)	not null,
	primary key(IdProduto))

create table Estoque(
	IdEstoque		integer			identity(1,1),
	IdProduto		integer			not null,
	DataVenda		date			not null,
	Quantidade		integer			not null,
	primary key(IdEstoque),
	foreign key(IdProduto)
		references Produto(IdProduto))

create table Vendido(
	IdVendido			integer			identity(1,1),
	IdProduto			integer			not null,
	QuantidadeVendido	integer			not null,
	DataVenda			date			not null,
	primary key(IdVendido),
	foreign key(IdProduto)
		references Produto(IdProduto))