# Relatório de Métricas - Criando Métricas Personalizadas

## 1. Introdução

Este relatório descreve o desenvolvimento e implementação de métricas personalizadas seguindo o tutorial fornecido pela Microsoft. O objetivo foi compreender e aplicar as práticas recomendadas para criar e coletar métricas em aplicativos .NET.

## 2. Desenvolvimento

### 2.1 Passo a Passo do Tutorial

1. **Codificação de Todas as Etapas**:
   - Segui todos os passos fornecidos no tutorial para criar métricas personalizadas.
   - Inicializei um novo projeto de console .NET para cada exemplo do tutorial.
   - Adicionei as referências necessárias aos pacotes NuGet conforme orientado.

2. **Criação de Métricas Personalizadas**:
   - Implementei a criação de métricas personalizadas conforme o primeiro exemplo do tutorial.
   - Utilizei a classe `Meter` para criar um grupo de instrumentos e o método `CreateCounter` para criar um contador de vendas de chapéus.
   - Simulei a venda de chapéus em intervalos regulares e registrei as vendas usando o método `Add` do contador.
  ![image](https://github.com/sophiatosarr/Criando-metricas/assets/99216420/6cefbee0-c102-4ea5-9bc0-9c1e4066e688)
![image](https://github.com/sophiatosarr/Criando-metricas/assets/99216420/cf908b10-f498-48aa-9223-3cca0f27ce0e)
![image](https://github.com/sophiatosarr/Criando-metricas/assets/99216420/0744f308-12c8-4036-b8c9-3533ec6779e6)




3. **Obtenção de um Medidor por meio da Injeção de Dependência**:
   - Implementei a obtenção de um medidor por meio da injeção de dependência conforme o segundo exemplo do tutorial.
   - Criei a classe `HatCoMetrics` para encapsular a lógica de registro de vendas de chapéus.
   - Utilizei o `IMeterFactory` para criar o medidor e o método `CreateCounter` para criar o contador de vendas de chapéus
   ![image](https://github.com/sophiatosarr/Criando-metricas/assets/99216420/a8933373-8e30-49ff-8e25-954cea493bca)
![image](https://github.com/sophiatosarr/Criando-metricas/assets/99216420/6c0c5063-8a19-4dd1-be5f-667c1e2b0e32)

    

## 3. Métricas Coletadas: Número de Chapéus Vendidos

- **Descrição:** Esta métrica rastreia o número total de chapéus vendidos durante a simulação.
- **Nome da Métrica:** `hatco.store.hats_sold`
- **Tipo de Métrica:** Contador de Inteiro

## 4. Conclusão

O desenvolvimento das métricas personalizadas foi concluído com sucesso, seguindo as etapas detalhadas no tutorial fornecido. Este relatório documenta o processo de implementação e a coleta de métricas, demonstrando a compreensão e aplicação dos conceitos discutidos.
