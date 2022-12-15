# tech-test-payment-api

Este repositorio tem intuito de simular um teste técnico feito pela Dio. Você vera diversos assuntos abordados neste pprojeto.<br>
ENtre elese:<br>
-DDD<br>
-Entity Framework<br>
-Modelagem de classes<br>
-API<br>
-Autommaper<br>
-Injesão de dependencia<br>

Entre outros assuntos.<br>


Para clonar este repositorio basta:<br>
git clone https://github.com/guismeiram/tech-test-payment-api<br>

Gerar o banco:<br>
Update-DataBase -Context PaymentDbContext<br>


INSTRUÇÕES PARA O TESTE TÉCNICO<br>
Crie um fork deste projeto (https://gitlab.com/Pottencial/tech-test-payment-api/-/forks/new). É preciso estar logado na sua conta Gitlab;
Adicione @Pottencial (Pottencial Seguradora) como membro do seu fork. Você pode fazer isto em: https://gitlab.com/`your-user`/tech-test-payment-api/settings/members ;
Quando você começar, faça um commit vazio com a mensagem "Iniciando o teste de tecnologia" e quando terminar, faça o commit com uma mensagem "Finalizado o teste de tecnologia";<br>
Commit após cada ciclo de refatoração pelo menos;<br>
Não use branches;<br>
Você deve prover evidências suficientes de que sua solução está completa indicando, no mínimo, que ela funciona;<br>
O TESTE<br>
Construir uma API REST utilizando .Net Core, Java ou NodeJs (com Typescript);<br>
A API deve expor uma rota com documentação swagger (http://.../api-docs).<br>
A API deve possuir 3 operações:<br>
Registrar venda: Recebe os dados do vendedor + itens vendidos. Registra venda com status "Aguardando pagamento";<br>
Buscar venda: Busca pelo Id da venda;<br>
Atualizar venda: Permite que seja atualizado o status da venda.<br>
OBS.: Possíveis status: <br>
Pagamento aprovado	Enviado para transportadora	Entregue	Cancelada<br>
Uma venda contém informação sobre o vendedor que a efetivou, data, identificador do pedido e os itens que foram vendidos;<br>
O vendedor deve possuir id, cpf, nome, e-mail e telefone;<br>
A inclusão de uma venda deve possuir pelo menos 1 item;<br>
A atualização de status deve permitir somente as seguintes transições:<br>
De: Aguardando pagamento  Para: Pagamento Aprovado<br>
De: Aguardando pagamento   Para: Cancelada<br>
De: Pagamento Aprovado    Para: Enviado para Transportadora<br>
De: Pagamento Aprovado   Para: Cancelada<br>
De: Enviado para Transportador. Para: Entregue<br>
A API não precisa ter mecanismos de autenticação/autorização;<br>
A aplicação não precisa implementar os mecanismos de persistência em um banco de dados, eles podem ser persistidos "em memória".<br>
PONTOS QUE SERÃO AVALIADOS<br>
Arquitetura da aplicação - embora não existam muitos requisitos de negócio, iremos avaliar como o projeto foi estruturada, bem como camadas e suas responsabilidades;<br>
Programação orientada a objetos;<br>
Boas práticas e princípios como SOLID, DDD (opcional), DRY, KISS;<br>
Testes unitários;<br>
Uso correto do padrão REST;<br>
Agora é sua vez de se destacar! Implemente todos os conceitos que aprendemos até aqui para a construção da sua API REST. Seja criativo e aproveite todos os conhecimentos adquiridos até aqui. <br><br>

Bons Estudos! 
