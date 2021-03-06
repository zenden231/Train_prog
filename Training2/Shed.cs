﻿using System;

namespace Training2
{
    class Shed
    {
        #region Shed dimension
        int heigh;
        /// <summary>
        /// Сокращенное объявление свойстава без переменной
        /// </summary>
        public int _width
        {
            get;
            set;
        }
        /// <summary>
        /// Свойство переменной в полном виде
        /// </summary>
        public int _heigh
        {
            get { return heigh; }
            set { heigh = value; }
        }
        /// <summary>
        /// Сокращенное объявление свойстава без переменной (жоское сокращение!11)
        /// </summary>
        public int _lengthwise { get; set; }
        /// <summary>
        /// Считает объем объекта Shed(сарай)
        /// </summary>
        /// <returns></returns>
        public int GetSize()
        {
            int size = _width * heigh * _lengthwise;
            return size;
        }
        /// <summary>
        /// Изменяет параметры объекта на заданное число (х, у, z)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        #endregion
        public void ExpandSize(int x, int y, int z)
        {
            _heigh += x;
            _width += y;
            _lengthwise += z;
        }
        /// <summary>
        /// Get variables and then change them 
        /// </summary>
        /// <param name="vx"></param>
        /// <param name="vy"></param>
        /// <param name="vz"></param>
        public void GetAndExpandSize(ref int vx, ref int vy, ref int vz)
        {
            ExpandSize(vx, vy, vz);
            vy = _width;
            vx = _heigh;
            vz = _lengthwise;
        }
    }
}