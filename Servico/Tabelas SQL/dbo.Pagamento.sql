CREATE TABLE [dbo].[Pagamento] (
    [id]             INT        IDENTITY (1, 1) NOT NULL,
    [funcionario_id] INT        NULL,
    [dataPagamento]  DATE       NULL,
    [mesReferente]   INT        NULL,
    [anoReferente]   INT        NULL,
    [valorPago]      FLOAT NULL,
    CONSTRAINT [PK_Pagamento] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Pagamento_Funcionario] FOREIGN KEY ([funcionario_id]) REFERENCES [dbo].[Funcionario] ([id])
);

