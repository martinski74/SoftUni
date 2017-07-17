﻿using System;
using System.Text;

public abstract class Provider : Worker
{
    private string id;
    private double energyOutput;

    protected Provider(string id, double energyOutput) : base(id)
    {
        this.Id = id;
        this.energyOutput = energyOutput;
    }

    public string Id
    {
        get { return this.id; }
        protected set { this.id = value; }
    }

    public double EnergyOutput
    {
        get { return this.energyOutput; }
        protected set
        {
            if (value < 0 || value > 10000)
            {
                throw new ArgumentException($"Provider is not registered, because of it's EnergyOutput");
            }
            this.energyOutput = value;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        var type = this.GetType().Name;
        var index = type.IndexOf("Provider");
        type = type.Remove(index);

        sb.AppendLine($"{type} Provider - {this.Id}");
        sb.AppendLine($"Energy Output: {this.EnergyOutput}");

        return sb.ToString().Trim();
    }
}

