# Desafio nas Alturas - Multiplayer Edition ⚔️✈️

Esta branch contém a **versão Multiplayer Local (Split-Screen)** do jogo "Desafio nas Alturas".

Desenvolvido como evolução do projeto original de Ciência da Computação (UFAL), o objetivo aqui foi refatorar a arquitetura base do jogo para suportar múltiplas instâncias de jogadores, câmeras e inputs simultâneos, saindo de um padrão *Singleton* rígido para um sistema mais flexível e orientado a eventos.

## ✨ O que há de novo?

* **Multijogador Local (Split-Screen):** O jogo agora divide a tela (Viewports) permitindo que dois jogadores compitam no mesmo teclado.
* **Lógica Desacoplada:** O `Diretor` (Game Manager) foi reescrito para aceitar injeção de dependência, gerenciando o estado de morte e pontuação de cada jogador individualmente.

## 🎮 Como Jogar (Download)

Você pode baixar a versão executável desta branch (Single + Multiplayer) na página de Releases:

1.  Acesse a aba **[Releases](../../releases)**.
2.  Procure pela tag mais recente (ex: `v2.0-Multiplayer`).
3.  Baixe o `.zip`, extraia e execute o arquivo.

**Controles Padrão:**
* **Jogador 1 (Cima):** Tecla `A`
* **Jogador 2 (Baixo):** Tecla `L`

## 🛠️ Tecnologias e Arquitetura

* **Engine:** Unity 6
* **Linguagem:** C#
* **Padrões de Projeto:** Observer Pattern (Eventos de Input) e Dependency Injection (Câmeras).

## 📁 Sobre esta Branch

Esta branch `multiplayer` diverge da `main` na estrutura das Cenas e na lógica dos inputs.

* **Main:** Focada na estabilidade e na experiência SinglePlayer clássica.
* **Multiplayer:** Focada na complexidade de gerenciamento de múltiplos atores e refatoração de código legado.

---
Desenvolvido por **Enrique Ferreira da Silva** com auxílio do Professor Ricardo Bugan (Curso Alura).
