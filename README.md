# Desafio-nas-Alturas-2D-Game-Unity-

Este projeto é um jogo de avião inspirado na mecânica clássica de Flappy Bird, desenvolvido como parte dos meus estudos acadêmicos em **Ciência da Computação na UFAL** e na ferramente de desenvolvimento de games **Unity**. O objetivo principal foi aplicar conceitos de Programação Orientada a Objetos (POO), gerenciamento de física 2D e arquitetura de sistemas de jogos.

## ✨ Funcionalidades Implementadas

* **Dificuldade Dinâmica:** Algoritmo que escala a dificuldade do jogo com base no tempo de sobrevivência, aumentando a velocidade dos obstáculos de forma progressiva.
* **Feedback Visual e Sonoro:** Sistema de *Camera Shake* em colisões e gerenciamento de estados de áudio.
* **Arquitetura de Controle:** Uso de um objeto `Diretor` centralizado para coordenar a lógica de fim de jogo, pontuação e reinício de estados.
* **Restrições Físicas:** Implementação de limites de tela (teto e chão) e detecção de colisões via *Tags* e *Triggers*.

## 🛠️ Tecnologias Utilizadas

* **Engine:** Unity 6
* **Linguagem:** C#

## 📁 Estrutura do Repositório

O repositório está organizado de forma a manter apenas o código-fonte e os recursos essenciais, seguindo as melhores práticas da indústria:

* **Assets/**: Contém todos os Scripts, Scenes, Áudios e Sprites.
* **Packages/**: Lista de dependências do projeto.
* **ProjectSettings/**: Configurações globais do projeto (Tags, Layers, Input).
* **.gitignore**: Filtro para exclusão de arquivos temporários e cache da Unity (Library, Temp, Logs).

## 🚀 Como Executar

1. Clone o repositório: `git clone https://github.com/Henry-016/Desafio-nas-Alturas-2D-Game-Unity-.git`
2. Abra a pasta do projeto no **Unity Hub**.
3. Localize e abra a cena principal em `Assets/Scenes/`.
4. Pressione **Play** no editor da Unity.

---
Desenvolvido por **Enrique Ferreira da Silva**.
