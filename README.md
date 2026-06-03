# 🛒 Lista de Compras

[![.NET 10](https://img.shields.io/badge/.NET-8.0-purple.svg)](https://dotnet.microsoft.com/)
[![ASP.NET Core MVC](https://img.shields.io/badge/ASP.NET-MVC-blue.svg)](https://learn.microsoft.com/aspnet/core/mvc/)
[![Architecture](https://img.shields.io/badge/Architecture-3--Tier%20%2F%20DDD-green.svg)]()

> O projeto **Lista de Compras** nasceu para resolver um problema real: ajudar a dona Maria a organizar suas compras semanais, evitando o esquecimento de itens essenciais e eliminando o desperdício com produtos que ela já possui em estoque.

---

## 📺 Demonstração da Aplicação

*(Substitua os links abaixo pelos GIFs de funcionamento das suas telas para garantir a pontuação máxima no critério de Documentação!)*

![Fluxo Principal do Sistema](https://via.placeholder.com/800x450.gif?text=Insira+aqui+o+GIF+do+seu+sistema+rodando)

---

## 🛠️ Arquitetura e Boas Práticas (.NET & ASP.NET MVC)

O sistema foi desenvolvido seguindo rigorosamente os padrões de mercado exigidos, garantindo baixo acoplamento, alta testabilidade e código limpo:

*   **Modelo de 3 Camadas Modular:** Separação clara de responsabilidades entre **Apresentação (MVC)**, **Domínio (Camada de Aplicação/Services)** e **Infraestrutura (Persistência)**.
*   **Injeção de Dependência:** Utilização do container nativo do .NET para promover o desacoplamento das classes.
*   **ViewModels & Records:** Uso de `ViewModels` para a comunicação segura com a interface e `Records` para a imutabilidade de DTOs.
*   **AutoMapper:** Mapeamento inteligente entre entidades de domínio e visões, eliminando código repetitivo.
*   **Extension Methods & Lambdas:** Uso de métodos de extensão para encapsular comportamentos reutilizáveis e expressões Lambda para manipulação ágil de coleções.
*   **Serialização de Dados:** Persistência robusta dos dados em arquivos locais na camada de Infraestrutura.

---

## 🚀 Módulos e Regras de Negócio Implementadas

### 1. Módulo de Categorias
*   **Funcionalidades:** Cadastro, edição, exclusão e visualização de categorias.
*   **Validações:** Nome único (máximo 50 caracteres) e seleção de Cor (Hexadecimal/Paleta).
*   *Regra Crítica:* Não é permitida a exclusão de categorias que possuam produtos vinculados.

### 2. Módulo de Produtos
*   **Funcionalidades:** CRUD completo integrado às categorias.
*   **Validações:** Nome (2 a 100 caracteres), categoria obrigatória, unidade de medida (kg, un, l, cx) e preço aproximado.
*   *Regra Crítica:* Bloqueio de produtos com nomes duplicados dentro da **mesma** categoria.

### 3. Módulo de Listas de Compras
*   **Funcionalidades:** Gerenciamento de listas com controle de estado.
*   **Validações:** Nome da lista (3 a 100 caracteres), data de criação automática e status dinâmico (Aberta / Concluída).
*   *Indicadores:* Exibição em tempo real do total de itens e do valor total estimado da lista.
*   *Regra Crítica:* Bloqueio de exclusão para listas que já contenham itens vinculados.

### 4. Módulo de Itens da Lista
*   **Funcionalidades:** Adição, remoção e listagem de itens vinculados.
*   **Validações:** Quantidade positiva e exibição automática da categoria ao selecionar o produto.
*   *Regra Crítica:* Impossibilidade de duplicar o mesmo produto dentro da mesma lista de compras. O valor total é recalculado automaticamente ($Preço \times Quantidade$).

---

## 🧪 Validações de Dados (Segurança do Input)

A integridade do sistema é garantida em duas frentes:
1.  **Camada de Visão:** Uso extensivo de `DataAnnotations` nas ViewModels para feedback imediato ao usuário.
2.  **Camada de Controle:** Validação estrita do `ModelState` antes de qualquer processamento de dados, acompanhada do uso correto de `TempData` para notificações contextuais entre requisições (mensagens de sucesso/erro).

---

## 💻 Como Executar o Projeto

### Pré-requisitos
*   [.NET SDK 10.0](https://dotnet.microsoft.com/download/dotnet/8.0)
*   IDE de sua preferência (Visual Studio 2022, VS Code ou JetBrains Rider)

### Passo a Passo

1. **Clonar o repositório:**
```bash
   git clone [https://github.com/seu-usuario/lista-de-compras.git](https://github.com/seu-usuario/lista-de-compras.git)
   cd lista-de-compras
