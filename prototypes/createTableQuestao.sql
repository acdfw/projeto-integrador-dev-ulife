IF EXISTS(SELECT 1 FROM sys.tables WHERE object_id = OBJECT_ID('questao'))
BEGIN;
    DROP TABLE [questao];
END;
GO

CREATE TABLE [questao] (
    [id] UNIQUEIDENTIFIER,
    [enunciado] VARCHAR(MAX) NULL,
    [professor_id] VARCHAR(MAX) NULL,
    PRIMARY KEY ([id])
);
GO

INSERT INTO [questao] (id,enunciado,professor_id)
VALUES
(  '23A50283-E406-EC39-347D-6D68044B2617','Procurando minimizar o número de spams que uma empresa recebe, os administradores de rede resolveram implementar a técnica de greylist, que consiste em: ', 'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  '3A6B406E-D83E-1E26-149E-1E19F268759A','Em relação a assinaturas digitais, analise as afirmativas a seguir: I. Certificado categoria S2 é o certificado usado para assinatura digital, com tamanho mínimo de 1024 bits, gerado por software e armazenado em um token. II. A verificação da assinatura digital de um documento eletrônico é realizada através da chave pública do remetente do documento. III. O DSA, algoritmo usado para assinaturas digitais, possui uma variante que utiliza curvas elípticas. Está correto somente o que se afirma em:' ,  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  '568DBB92-A5DE-8C2D-EAFD-973D8187CD8D','Uma empresa deseja ser certificada na implementação da norma ISO 27001. Para tal, ela deve seguir com rigor o que preconiza a norma, como por exemplo:' ,  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  '7A31BC13-5D1C-CFC2-49B5-62660A6C64A2','Para criptografar mensagens de tamanho arbitrário, existem vários modos de operação especificando como a criptografia será aplicada. Um desses modos é frágil em termos de segurança, pois não oculta o padrão de dados da mensagem original, mantendo-o na mensagem codificada. Esse modo de operação, menos seguro, é o:',  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  '2F936AE7-6B77-3ED8-CA4A-77945F856612','O número inteiro –2 (menos dois) tem a seguinte representação em 16 bits, usando complemento a 2:' ,  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  'C8D6156D-7476-5647-E7C3-8DE0D22591D6','O resultado da multiplicação entre os inteiros 7F16 x 1216, ambos representados em complemento a 2 na base 16' ,  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  'BC358B5E-6D78-34C6-0468-837ECA522878','O acesso a dados em registradores internos da Unidade Central de Processamento (UCP):' ,  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  '9EE513A7-A4B7-A4D9-DA5A-A1659DCF827C','A estratégia de alocação de memória que busca o menor espaço livre suficiente para satisfazer cada requisição denomina-se:' ,  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  '783A2951-A279-A225-AE16-95CBB34DC7FB','Segundo Ian Sommerville, as arquiteturas orientadas a serviços (SOA) são uma forma de desenvolvimento de sistemas distribuídos em que os componentes de sistema são serviços autônomos, executando em computadores geograficamente distribuídos. Para que  acesso a esses serviços ocorra, são utilizados alguns padrões, dentre os quais estão o SOAP, WSDL e WS-BPEL. A linguagem WSDL é baseada em XML e tem como função especificar um serviço (web service) considerando os seguintes aspectos:',  'EC44538B-C8D3-8842-D336-8C4E371B7B9E'),
(  'A84864C2-B45C-B065-BBB4-30869B3CD110','Cristiano implementou o syslog nos servidores Linux que administra com o intuito de enviar todas as mensagens de log para um único servidor, que centralizará todos os logs da rede. Cristiano não está preocupado com a quantidade de mensagens de log  transmitidas entre os clientes e o servidor centralizador de log, pois:',  'EC44538B-C8D3-8842-D336-8C4E371B7B9E');
