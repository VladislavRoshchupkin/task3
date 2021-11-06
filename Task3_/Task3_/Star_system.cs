using System;
using System.Collections.Generic;

public class Star_system
{
	private string name;

	private List<Planet> planetList = new List<Planet>();

	public Star_system(string _name)
	{
		name = _name;
	}

	public void addPlanet(Planet planet)
	{
		planetList.Add(planet);
	}

	public string getName()
	{
		return name;
	}

	public List<Planet> getPlanetList()
	{
		return planetList;
	}
}
