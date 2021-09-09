namespace FactoryPattern_Kata
{
	public class LicenseManager
	{
		public static bool CheckActivation(ActivationData activationData, License license)
		{
			//change the solution so the following code will work instead of the uncommented one ( that should be gone)
			/*
				IChecker checker = CheckerFactory.CreateChecker(license.LicenseType);
				checker.Check(activationData, license);
			 */
			if (license.LicenseType == LicenseType.NoCheck)
			{
				if (activationData.Date > license.MaxActivations)
					return false;

				return true;
			}
			if (license.LicenseType == LicenseType.Check)
			{
				if (activationData.Date > license.MaxActivations)
					return false;

				if (license.Activations.Count != license.LimitOfActivations)
					return true;

				return license.Activations.Contains(activationData.HardwareId);
			}

			return false;
		}
	}
}