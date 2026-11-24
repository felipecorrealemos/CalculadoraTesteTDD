# 🧪 Testes de Software – Calculadora TDD

## 📚 Sobre o projeto

Projeto didático desenvolvido para a disciplina de Lógica e Linguagem de Programação do curso Técnico em Desenvolvimento de Sistemas.

A aplicação simula uma calculadora com quatro operações matemáticas que apresentam erros propositais em suas regras de negócio.

Sua missão será implementar testes, identificar falhas, corrigir os cálculos e aplicar os conceitos de refatoração de código.

## 🛠️ Tecnologias utilizadas

- C#
- .NET MAUI
- Blazor Hybrid
- Bootstrap
- HTML e CSS
- Visual Studio

## 🔄 Ciclo TDD

O TDD (Test Driven Development), ou Desenvolvimento Guiado por Testes, utiliza um ciclo composto por três etapas.

| Etapa | Descrição |
|---|---|
| 🔴 Red | Criar e executar um teste que apresente uma falha. |
| 🟢 Green | Implementar ou corrigir o código para que o teste seja aprovado. |
| 🔵 Refactor | Melhorar o código sem alterar seu comportamento esperado. |

Nesta atividade, utilizaremos uma adaptação didática desse ciclo para testar funcionalidades existentes.

## 📁 Estrutura do projeto

| Arquivo | Responsabilidade |
|---|---|
| `Services/CalculadoraService.cs` | Classe responsável pelas operações matemáticas. |
| `Components/Pages/Testes.razor` | Interface gráfica e implementação dos testes. |
| `NavMenu.razor` | Menu de navegação da aplicação. |

## 🚀 Como executar o projeto

1. Clone ou baixe este repositório.
2. Abra o projeto no Visual Studio.
3. Aguarde a restauração das dependências.
4. Execute a aplicação utilizando o destino Windows Machine.
5. Acesse a opção **Testes de Software** no menu lateral.
6. Clique no botão **Executar testes**.

## 🧮 Operações que serão testadas

| Operação | Entrada | Resultado esperado |
|---|---|---:|
| Soma | 100 + 50 | 150 |
| Subtração | 100 − 50 | 50 |
| Multiplicação | 10 × 5 | 50 |
| Divisão | 100 ÷ 2 | 50 |

Todas as operações apresentam erros propositais. Não confunda esses erros com problemas de instalação ou configuração do projeto.

## 🎯 Atividade prática

### Etapa 1 – Analisar a aplicação

- Execute o projeto.
- Observe os resultados apresentados.
- Compare os valores recebidos com os valores esperados.
- Identifique quais operações apresentam resultados incorretos.

### Etapa 2 – Ativar os testes existentes

- Abra o arquivo `Testes.razor`.
- Localize o método `ExecutarTestes()`.
- Localize os testes da soma e da subtração.
- Descomente os blocos de código.
- Execute novamente a aplicação.
- Observe as mensagens de erro.

### Etapa 3 – Implementar novos testes

Utilizando os testes anteriores como referência:

- Implemente o teste da multiplicação.
- Implemente o teste da divisão.
- Utilize estruturas condicionais `if` e `else`.
- Compare o valor recebido com o valor esperado.
- Apresente a mensagem correspondente ao resultado do teste.
- Execute novamente a aplicação.

### Etapa 4 – Corrigir as funcionalidades

- Abra o arquivo `CalculadoraService.cs`.
- Analise os quatro métodos matemáticos.
- Identifique os erros nas operações.
- Corrija as regras de negócio.
- Execute novamente todos os testes.

### Etapa 5 – Refatorar o código

- Substitua os nomes genéricos dos parâmetros por nomes mais descritivos.
- Adicione comentários explicando a finalidade dos métodos.
- Melhore a legibilidade do código.
- Execute novamente os testes para garantir que as alterações não introduziram novas falhas.

## 🚦 Status dos testes

| Status | Significado |
|---|---|
| ⚪ Teste não implementado | A verificação ainda não foi implementada ou ativada. |
| 🔴 Teste falhou | O resultado recebido é diferente do esperado. |
| 🟢 Teste passou | O resultado recebido corresponde ao esperado. |

## ⚠️ Regras da atividade

- Não altere os valores esperados para fazer os testes passarem.
- Implemente os testes antes de corrigir as operações matemáticas.
- Não modifique a interface gráfica desnecessariamente.
- Não utilize bibliotecas externas de testes.
- Não remova as verificações implementadas.
- Execute novamente os testes após cada alteração.
- Corrija a causa do problema, e não apenas a mensagem de erro.

## 💬 Questões para reflexão

1. Qual é a importância de definir o resultado esperado antes de executar um teste?
2. Como os testes automatizados ajudam a identificar erros de programação?
3. Por que devemos executar novamente os testes após refatorar um código?

## 🏁 Resultado final esperado

Ao concluir a atividade, o painel de execução deverá apresentar:

```
[SOMA] TESTE PASSOU
[SUBTRAÇÃO] TESTE PASSOU
[MULTIPLICAÇÃO] TESTE PASSOU
[DIVISÃO] TESTE PASSOU
```

## ✅ Checklist de conclusão

- [ ] Executei a aplicação.
- [ ] Ativei o teste da soma.
- [ ] Ativei o teste da subtração.
- [ ] Implementei o teste da multiplicação.
- [ ] Implementei o teste da divisão.
- [ ] Identifiquei os erros matemáticos.
- [ ] Corrigi as quatro operações.
- [ ] Refatorei os métodos.
- [ ] Todos os testes foram aprovados.

---

**Curso:** Técnico em Desenvolvimento de Sistemas

**Disciplina:** Lógica e Linguagem de Programação

**Tema:** Testes de Software, TDD, Depuração e Refatoração.

Projeto desenvolvido exclusivamente para fins educacionais.
