<a href="https://www.wexinc.com/pt-br/" target="_blank"><img src="logo_wex.jpg" width="60" height="15"></a> **END TO END ENGINEERING**   

<a href="http://www.dio.me" target="_blank"> <img src= "logo_dio.jpg" width="40" height="15"></a>  **Trilha .NET - Fundamentos**
 

## SISTEMA DE ESTACIONAMENTO  

## Melhorias no Projeto  
Foram feitas algumas modificações no sistema, focadas em aprimorar a experiência do usuário e a eficiência das funcionalidades. As principais alterações incluem:
- **Adição de opções interativas (Y/N)** para melhorar a navegação e tornar a interação mais intuitiva.
- **Aprimoramento das funcionalidades** para otimizar o fluxo de execução e oferecer uma experiência mais dinâmica.
- **Correções de possíveis inconsistências** e ajustes no código para garantir um funcionamento mais estável e eficiente.
Essas melhorias visam tornar o sistema mais acessível e responsivo, proporcionando uma interação mais fluida. 

**Caso tenha sugestões ou encontre pontos que podem ser refinados, fique à vontade para contribuir!**  

// PSEUDOCÓDIGO — Próxima Etapa: Criar Fluxograma  

INÍCIO  
    Exibir mensagem de boas-vindas  
    Solicitar valor inicial do estacionamento  
    Ler entrada do usuário  
    Limpar tela  
    Solicitar valor por hora adicional  
    Ler entrada do usuário  
    Limpar tela  
    Exibir menu principal  

MENU PRINCIPAL  
    Enquanto usuário não escolher "Encerrar"  
        Exibir opções do menu  
        Ler entrada do usuário  
        Se opção for "1" então  
            Executar função AdicionarVeiculo()  
        Se opção for "2" então  
            Executar função RemoverVeiculo()  
        Se opção for "3" então  
            Executar função ListarVeiculos()  
        Se opção for "4" então  
            Encerrar programa  
    FIM ENQUANTO  

FUNÇÃO AdicionarVeiculo()  
    Limpar tela  
    Solicitar placa do veículo  
    Ler entrada do usuário  
    Exibir mensagem de sucesso  
    Aguardar tecla para retornar ao menu  
    Limpar tela  
    Exibir menu  

FUNÇÃO RemoverVeiculo()  
    Limpar tela  
    Exibir mensagem: "Deseja exibir a lista de veículos? (Y/N)"  
    Ler entrada do usuário  
    Se entrada for "Y" então  
        Exibir lista de veículos  
        Solicitar placa do veículo a remover  
    Se entrada for "N" então  
        Solicitar placa diretamente  
    Se placa estiver correta então  
        Solicitar quantidade de horas estacionado  
        Ler entrada do usuário  
        Calcular valor total  
        Exibir mensagem de remoção e valor a pagar  
        Aguardar tecla para retornar ao menu  
    Se placa estiver errada então  
        Exibir mensagem: "Placa não encontrada! Deseja tentar novamente? (Y/N)"  
        Se entrada for "Y" então  
            Chamar novamente RemoverVeiculo()  
        Se entrada for "N" então  
            Retornar ao menu  
    Limpar tela  
    Exibir menu  

FUNÇÃO ListarVeiculos()  
    Se não houver veículos estacionados então  
        Exibir mensagem: "Não há veículos estacionados"  
    Se houver veículos estacionados então  
        Exibir lista de veículos  
    Aguardar tecla para retornar ao menu  
    Limpar tela  
    Exibir menu  

FUNÇÃO Encerrar()  
    Limpar tela  
    Exibir mensagem de encerramento  
    Finalizar programa  

FIM  
 
--------------------------------------------------------------------------------

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de fundamentos, da trilha .NET da DIO.

## Contexto
Você foi contratado para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

## Proposta
Você precisará construir uma classe chamada "Estacionamento", conforme o diagrama abaixo:
![Diagrama de classe estacionamento](diagrama_classe_estacionamento.png)

A classe contém três variáveis, sendo:

**precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

**precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

**veiculos**: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

A classe contém três métodos, sendo:

**AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável **veiculos**.

**RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: **precoInicial** * **precoPorHora**, exibindo para o usuário.

**ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

Por último, deverá ser feito um menu interativo com as seguintes ações implementadas:
1. Cadastrar veículo
2. Remover veículo
3. Listar veículos
4. Encerrar


## Solução
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.
