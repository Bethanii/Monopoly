﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyGame
{
    public class Property
    {
        protected String name;
        protected String type;
        protected Player owner;
        protected int cost;
        protected int boardPosition;

        public String getName()
        {
            return name;
        }
        public Player getOwner()
        {
            return owner;
        }
        public void setOwner(Player owner)
        {
            this.owner = owner;
        }
        public int getCost()
        {
            return cost;
        }

        public int getBoardPosition()
        {
            return boardPosition;
        }
        public String getType()
        {
            return type;
        }
        public virtual String getColorGroup()
        {
            return "";
        }
        public virtual int getRent(int roll)
        {
            return 0;
        }

        public virtual int getHousePrice()
        {
            return 0;
        }
        public virtual int getHouseCount()
        {
            return 0;
        }
        public virtual void setHouseCount(int houseCount)
        {
            
        }
        public virtual int getColorGroupSize()
        {
            return 0;
        }
    }
}