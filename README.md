# MinhasDespesas - Gerenciador Financeiro Pessoal

Este é um projeto de Gerenciador Financeiro Pessoal desenvolvido no âmbito do **Projeto OSB (Construindo uma Plataforma de White Label Open Banking para Melhorar a Inclusão Financeira e Capital Humano em Russas, Nordeste do Brasil)**.

O projeto foi supervisionado pela **Profa. Dra. Patrícia Freitas Campos de Vasconcelos** e busca ser uma demonstração prática das tecnologias aprendidas nos cursos e capacitações disponibilizadas pelo próprio projeto.

O sistema permite que um usuário se cadastre, gerencie suas categorias de gastos e registre suas despesas diárias, visualizando tudo em um dashboard interativo com resumos e gráficos.

---

### Tecnologias Utilizadas

* **ASP.NET Core 8**: Para a estrutura principal do projeto.
* **Entity Framework Core 8**: Para o acesso ao banco de dados (SQLite).
* **Razor Pages**: Para autenticação (Identity) e o CRUD de Categorias.
* **Blazor Server**: Para o Dashboard interativo (formulários, cards de resumo, gráficos).
* **Chart.js**: Para a renderização dos gráficos (via JS Interop).
* **Bootstrap 5**: Para o layout e componentes de UI.

---

### Como Rodar o Projeto

Você precisará ter o **SDK do .NET 8** instalado.

1.  **Clone o repositório:**
    ```bash
    git clone [https://github.com/CaduCarvalhoDev/MinhasDespesas.git](https://github.com/CaduCarvalhoDev/MinhasDespesas.git)
    ```

2.  **Navegue até a pasta do projeto:**
    ```bash
    cd MinhasDespesas
    ```

3.  **Crie o Banco de Dados (Passo Essencial):**
    Este projeto usa o Entity Framework Core Migrations. O banco de dados (`app.db`) não está no repositório. Para criá-lo localmente, rode o comando:
    ```bash
    dotnet ef database update
    ```

4.  **Execute o projeto:**
    ```bash
    dotnet run
    ```

5.  Abra seu navegador no endereço `http://localhost:XXXX` (a porta será indicada no seu terminal).

---

### Funcionalidades

* Autenticação de usuários (Registro e Login).
* Gerenciamento (CRUD) de Categorias de despesa.
* Dashboard interativo com:
    * Registro de novas despesas.
    * Cards de resumo (Total gasto no mês, Categoria principal).
    * Gráfico de pizza de gastos por categoria (atualizado em tempo real).
    * Lista de despesas recentes.
* Página de Histórico Completo com filtros por data e categoria.
* Exclusão de despesas com pop-up de confirmação.