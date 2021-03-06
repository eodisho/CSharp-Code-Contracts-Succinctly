// <copyright file="ERPWarehouseIntegrationTest.cs">Copyright ©  2015</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeContractsDemoProject.Tests
{
    /// <summary>This class contains parameterized unit tests for ERPWarehouseIntegration</summary>
    [PexClass(typeof(ERPWarehouseIntegration))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ERPWarehouseIntegrationTest
    {
        /// <summary>Test stub for ProductionVolumePerBin(Int32, Int32)</summary>
        [PexMethod(MaxBranches = 320000, MaxConstraintSolverTime = 2)]
        public int ProductionVolumePerBinTest(
            [PexAssumeUnderTest]ERPWarehouseIntegration target,
            int binVolume,
            int factor
        )
        {
            int result = target.ProductionVolumePerBin(binVolume, factor);
            return result;
            // TODO: add assertions to method ERPWarehouseIntegrationTest.ProductionVolumePerBinTest(ERPWarehouseIntegration, Int32, Int32)
        }
    }
}
