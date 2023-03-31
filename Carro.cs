using System;
using System.Globalization;

namespace logistica
{
	class Carro
	{	
		public string? tipoVeiculo {get; set;}
			
		public string? posicao, situacaoMecanica;
		
		public double combustivel, velocidade;
		
		public bool bloqueioTransito;

		
		public string PosicaoVeiculo()
		{
			Console.WriteLine("Informe sua localização");
			string? posicao = Console.ReadLine();
			return posicao;
		}
		
		public string situacaoMecanicaVeiculo()
		{
			Console.WriteLine("Informe a situação do veículo");
			string? situacaoMecanica = Console.ReadLine();
			string situacaoMecanicaUpper = situacaoMecanica.ToUpper();
			if(situacaoMecanicaUpper == "OKAY")
			{
				Console.WriteLine("Siga viagem, e continue checando seu veículo");
			}
			else if(situacaoMecanicaUpper == "BAD")
			{
				Console.WriteLine("O seu veículo será bloqueado");
			} else 
			{
				throw new InvalidDataException("Deu ruim e fechei o programa");
			}
			return situacaoMecanicaUpper;
		}
		
		public double combustivelVeiculo()
		{
			Console.WriteLine("Informe a quantidade de combustível abastecida");
			double combustivel = Convert.ToDouble(Console.ReadLine());
			if(combustivel < 10.0 && combustivel > 2.1)
			{
				Console.WriteLine("Complete o tanque");
			} 
			else if(combustivel<= 2.0 && combustivel > 1.1)
			{
				Console.WriteLine("Busque um posto próximo urgentemente");
			} 
			else if(combustivel<= 1.0)
			{
				Console.WriteLine("Abasteça urgentemente seu veículo");
			}
			else 
			{
				Console.WriteLine("Siga viagem com cuidado");
			}
			return combustivel;			
		}
		
		public double velocidadeVeiculo()
		{
			Console.WriteLine("Insira a velocidade média do veículo no trajeto");
			double velocidade =  Convert.ToDouble(Console.ReadLine());
			if(velocidade > 120.0)
			{
				Console.WriteLine("Seu veículo será bloqueado e você será encaminhado para uma avaliação");
			}
						
			return velocidade;
		}
		
		public bool bloqueioTransitoVeiculo()
		{
			if(velocidade > 120.0 || situacaoMecanica == "BAD") 
			{
				Console.WriteLine("Veículo Bloqueado");
				bloqueioTransito = true;
			} 
			else 
			{
				Console.WriteLine("Siga viagem com cuidado");
				bloqueioTransito = false;
			}
			return bloqueioTransito;
		}
	}
}
