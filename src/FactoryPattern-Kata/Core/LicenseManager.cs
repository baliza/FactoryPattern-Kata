namespace FactoryPattern_Kata
{
	public class LicenseManager
	{
		public static bool CheckActivation(ActivationData activationData, License license)
		{
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

				if (license.Activations.Count == license.LimitOfActivations)
				{
					if (!license.Activations.Contains(activationData.HardwareId))
						return false;
				}

				return true;
			}

			return false;
		}
	}
}