﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

[ServiceContract]
public interface IService
{
	[OperationContract]
	double[] StartGauss(double[] value, int size);
    [OperationContract]
    double[] GetObrMatrix(double[] value, int size);

}