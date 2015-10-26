﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bowling
{
    [TestFixture]
    public class TestBowling
    {
        [Test]
        public void AllZero()
        {
            Game g = new Game();
            for (int i = 0; i < 20; i++)
            {
                g.SetPins(0);
            }
            Assert.That(g.GetFinalScore(), Is.EqualTo(0));
        }
        [Test]
        public void FirstRound()
        {
            Game g = new Game();
            g.SetPins(5);
            g.SetPins(4);
            Assert.That(g.GetFinalScore(), Is.EqualTo(9));
        }
        [Test]
        public void TripleRound()
        {
            Game g = new Game();
            g.SetPins(1);
            g.SetPins(4);
            g.SetPins(4);
            g.SetPins(5);
            g.SetPins(3);
            Assert.That(g.GetFinalScore(), Is.EqualTo(37));
        }
       
    }
}

