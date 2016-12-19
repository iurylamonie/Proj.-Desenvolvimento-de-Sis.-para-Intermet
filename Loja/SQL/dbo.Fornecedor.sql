CREATE TABLE [dbo].[Fornecedor] (
    [codigo]           INT           IDENTITY (1, 1) NOT NULL,
    [nome]             VARCHAR (MAX) NULL,
    [telefone]         VARCHAR (MAX) NULL,
    [identidade]       VARCHAR (MAX) NULL,
    [carteiraTrabalho] VARCHAR (MAX) NULL,
    [salario]          FLOAT (53)    NULL,
    [motorista]        BIT           NULL,
    [tecnico]          BIT           NULL,
    [observacao]       VARCHAR (MAX) NULL,
    CONSTRAINT [PK_Fornecedor] PRIMARY KEY CLUSTERED ([codigo] ASC)
);

