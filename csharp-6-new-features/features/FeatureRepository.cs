using System.Linq;
using System.Collections.Generic;

namespace csharp_6.features
{
  public enum FeatureOption
  {
    UsingStatic,
    DictionayInit,
    AutoPropertyInt,
    Nameof,
    NullConditionalOperator,
    ExceptionFilters,
    ExpressionBodied,
    AwaitInCatchFinally,
    StringInterpolation
  }

  public static class FeatureRepository
  {
    private static Dictionary<FeatureOption, IFeature> features = new Dictionary<FeatureOption, IFeature>()
    {
      [FeatureOption.UsingStatic] = new UsingStaticFeature(),
      [FeatureOption.DictionayInit] = new DictionaryInitFeature(),
      [FeatureOption.AutoPropertyInt] = new AutoPropertyIntFeature(),
      [FeatureOption.Nameof] = new NameofFeature(),
      [FeatureOption.NullConditionalOperator] = new NullConditionalOperatorFeature(),
      [FeatureOption.ExceptionFilters] = new ExceptionFiltersFeature(),
      [FeatureOption.ExpressionBodied] = new ExpressionBodiedFeature(),
      [FeatureOption.AwaitInCatchFinally] = new AwaitInCatchFinallyFeature(),
      [FeatureOption.StringInterpolation] = new StringInterpolationFeature()
    };

    public static IFeature GetOne(FeatureOption value)
    {
      return features[value];
    }

    public static IFeature[] GetAll()
    {
      return features.Values.ToArray<IFeature>();
    }
  }
}
