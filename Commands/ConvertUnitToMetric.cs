using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;

namespace BaanRevit
{
    [Transaction(TransactionMode.Manual)]
    public class ConvertUnitToMetric : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            //Get UIDocument
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = uidoc.Document;


            try
            {

                Transaction transaction = new Transaction(doc);
                transaction.Start("Convert Unit");

                Units units = doc.GetUnits();

                //Length
                FormatOptions millimeter = new FormatOptions(DisplayUnitType.DUT_MILLIMETERS, 0.01);
                units.SetFormatOptions(UnitType.UT_Length, millimeter);          

                //Area
                FormatOptions area = new FormatOptions(DisplayUnitType.DUT_SQUARE_METERS, 0.01);
                units.SetFormatOptions(UnitType.UT_Area, area);

                //Volume
                FormatOptions volume = new FormatOptions(DisplayUnitType.DUT_CUBIC_METERS, 0.01);
                units.SetFormatOptions(UnitType.UT_Volume, volume);
                doc.SetUnits(units);

                //Angle
                FormatOptions angle = new FormatOptions(DisplayUnitType.DUT_DECIMAL_DEGREES, 0.01);
                units.SetFormatOptions(UnitType.UT_Angle, angle);

                //Slope
                FormatOptions slope = new FormatOptions(DisplayUnitType.DUT_SLOPE_DEGREES, 0.01);
                units.SetFormatOptions(UnitType.UT_Slope, slope);

                //MassDensity
                FormatOptions massDensity = new FormatOptions(DisplayUnitType.DUT_KILOGRAMS_PER_CUBIC_METER, 0.01);
                units.SetFormatOptions(UnitType.UT_MassDensity, massDensity);

                //Speed
                FormatOptions speed = new FormatOptions(DisplayUnitType.DUT_KILOMETERS_PER_HOUR, 0.01);
                units.SetFormatOptions(UnitType.UT_Speed, speed);

                //Force
                FormatOptions force = new FormatOptions(DisplayUnitType.DUT_KILONEWTONS, 0.01);
                units.SetFormatOptions(UnitType.UT_Force, force);

                //Linear Force
                FormatOptions linearForce = new FormatOptions(DisplayUnitType.DUT_KILONEWTONS_PER_METER, 0.01);
                units.SetFormatOptions(UnitType.UT_LinearForce, linearForce);

                //Area Force
                FormatOptions areaForce = new FormatOptions(DisplayUnitType.DUT_KILONEWTONS_PER_SQUARE_METER, 0.01);
                units.SetFormatOptions(UnitType.UT_AreaForce, areaForce);

                //Moment
                FormatOptions moment = new FormatOptions(DisplayUnitType.DUT_KILONEWTON_METERS, 0.01);
                units.SetFormatOptions(UnitType.UT_Moment, moment);

                //Linear Moment
                FormatOptions linearMoment = new FormatOptions(DisplayUnitType.DUT_KILONEWTON_METERS_PER_METER, 0.01);
                units.SetFormatOptions(UnitType.UT_LinearMoment, linearMoment);

                //Stress
                FormatOptions stress = new FormatOptions(DisplayUnitType.DUT_MEGAPASCALS, 0.1);
                units.SetFormatOptions(UnitType.UT_Stress, stress);

                //Unit Weight
                FormatOptions unitWeight = new FormatOptions(DisplayUnitType.DUT_KILONEWTONS_PER_CUBIC_METER, 0.01);
                units.SetFormatOptions(UnitType.UT_UnitWeight, unitWeight);

                //Weight
                FormatOptions weight = new FormatOptions(DisplayUnitType.DUT_KILONEWTONS, 0.1);
                units.SetFormatOptions(UnitType.UT_Weight, weight);

                //Mass
                FormatOptions mass = new FormatOptions(DisplayUnitType.DUT_KILOGRAMS_MASS, 0.01);
                units.SetFormatOptions(UnitType.UT_Mass, mass);

                //Mass per Unit Area
                FormatOptions massPerUnitArea = new FormatOptions(DisplayUnitType.DUT_KILOGRAMS_MASS_PER_SQUARE_METER, 0.01);
                units.SetFormatOptions(UnitType.UT_MassPerUnitArea, massPerUnitArea);

                //Thermal Expansion Coefficient
                FormatOptions thermalExpansionCofficient = new FormatOptions(DisplayUnitType.DUT_INV_CELSIUS, 0.001);
                units.SetFormatOptions(UnitType.UT_ThermalExpansion, thermalExpansionCofficient);

                //Displacement/Deflection
                FormatOptions pointSpringCoefficient = new FormatOptions(DisplayUnitType.DUT_CENTIMETERS, 0.1);
                units.SetFormatOptions(UnitType.UT_Displacement_Deflection, pointSpringCoefficient);

                //Rotation
                FormatOptions rotation = new FormatOptions(DisplayUnitType.DUT_DECIMAL_DEGREES, 0.001);
                units.SetFormatOptions(UnitType.UT_Rotation, rotation);

                //Period
                FormatOptions period = new FormatOptions(DisplayUnitType.DUT_SECONDS, 0.1);
                units.SetFormatOptions(UnitType.UT_Period, period);

                //Velocity
                FormatOptions velocity = new FormatOptions(DisplayUnitType.DUT_METERS_PER_SECOND, 0.1);
                units.SetFormatOptions(UnitType.UT_Structural_Velocity, velocity);

                //Acceleration
                FormatOptions acceleration = new FormatOptions(DisplayUnitType.DUT_METERS_PER_SECOND_SQUARED, 0.1);
                units.SetFormatOptions(UnitType.UT_Acceleration, acceleration);

                //Energy
                FormatOptions energy = new FormatOptions(DisplayUnitType.DUT_KILOJOULES, 0.1);
                units.SetFormatOptions(UnitType.UT_Energy, energy);

                //Reinforcement Volume
                FormatOptions reinforcement = new FormatOptions(DisplayUnitType.DUT_CUBIC_CENTIMETERS, 0.01);
                units.SetFormatOptions(UnitType.UT_Reinforcement_Volume, reinforcement);

                //Reinfocement Length
                FormatOptions reinforcementLength = new FormatOptions(DisplayUnitType.DUT_MILLIMETERS, 0.01);
                units.SetFormatOptions(UnitType.UT_Reinforcement_Length, reinforcementLength);

                //Reinforcement Area
                FormatOptions reinforceArea = new FormatOptions(DisplayUnitType.DUT_SQUARE_MILLIMETERS, 0.01);
                units.SetFormatOptions(UnitType.UT_Reinforcement_Area, reinforceArea);

                //Reinforcement Area per Unit Length
                FormatOptions reinforcementAreaPerUnitLenght = new FormatOptions(DisplayUnitType.DUT_SQUARE_CENTIMETERS_PER_METER, 0.01);
                units.SetFormatOptions(UnitType.UT_Reinforcement_Area_per_Unit_Length, reinforcementAreaPerUnitLenght);

                //Reinforcement Spacing
                FormatOptions reinforcementSpaceing = new FormatOptions(DisplayUnitType.DUT_MILLIMETERS, 0.1);
                units.SetFormatOptions(UnitType.UT_Reinforcement_Spacing, reinforcementSpaceing);

                //Reinforcement Cover
                FormatOptions reinforcementCover = new FormatOptions(DisplayUnitType.DUT_MILLIMETERS, 0.1);
                units.SetFormatOptions(UnitType.UT_Reinforcement_Cover, reinforcementCover);

                //Bar Diameter
                FormatOptions barDiameter = new FormatOptions(DisplayUnitType.DUT_MILLIMETERS, 0.1);
                units.SetFormatOptions(UnitType.UT_Bar_Diameter, barDiameter);

                //Crack Width
                FormatOptions crackWidth = new FormatOptions(DisplayUnitType.DUT_MILLIMETERS, 0.01);
                units.SetFormatOptions(UnitType.UT_Crack_Width, crackWidth);

                //Section Dimension
                FormatOptions sectionDimension = new FormatOptions(DisplayUnitType.DUT_CENTIMETERS, 0.01);
                units.SetFormatOptions(UnitType.UT_Section_Dimension, sectionDimension);

                //Section Property
                FormatOptions sectionProperty = new FormatOptions(DisplayUnitType.DUT_CENTIMETERS, 0.1);
                units.SetFormatOptions(UnitType.UT_Section_Property, sectionProperty);

                //Section Area
                FormatOptions sectionArea = new FormatOptions(DisplayUnitType.DUT_SQUARE_CENTIMETERS, 0.1);
                units.SetFormatOptions(UnitType.UT_Section_Area, sectionArea);

                //Section Modulus
                FormatOptions sectionModulus = new FormatOptions(DisplayUnitType.DUT_CUBIC_CENTIMETERS, 0.01);
                units.SetFormatOptions(UnitType.UT_Section_Modulus, sectionModulus);

                //Moment of Inertia
                FormatOptions MomentOfInertia = new FormatOptions(DisplayUnitType.DUT_CENTIMETERS_TO_THE_FOURTH_POWER, 0.01);
                units.SetFormatOptions(UnitType.UT_Moment_of_Inertia, MomentOfInertia);

                //Wraping Constant
                FormatOptions wrapingConstant = new FormatOptions(DisplayUnitType.DUT_CENTIMETERS_TO_THE_SIXTH_POWER, 0.1);
                units.SetFormatOptions(UnitType.UT_Warping_Constant, wrapingConstant);

                //Mass per Unit Length
                FormatOptions massPerUnitLength = new FormatOptions(DisplayUnitType.DUT_KILOGRAMS_MASS_PER_METER, 0.01);
                units.SetFormatOptions(UnitType.UT_Mass_per_Unit_Length, massPerUnitLength);

                //Weight per Unit Length
                FormatOptions weightPerUnitLength = new FormatOptions(DisplayUnitType.DUT_KILOGRAMS_FORCE_PER_METER, 0.01);
                units.SetFormatOptions(UnitType.UT_Weight_per_Unit_Length, weightPerUnitLength);

                //Surface Area Per Unit Length
                FormatOptions surfaceAreaPerUnitLength = new FormatOptions(DisplayUnitType.DUT_SQUARE_METERS_PER_METER, 0.01);
                units.SetFormatOptions(UnitType.UT_Surface_Area, surfaceAreaPerUnitLength);

                //Density
                FormatOptions density = new FormatOptions(DisplayUnitType.DUT_KILOGRAMS_PER_CUBIC_METER, 0.1);
                units.SetFormatOptions(UnitType.UT_HVAC_Density, density);

                //Friction
                FormatOptions friction = new FormatOptions(DisplayUnitType.DUT_PASCALS_PER_METER, 0.01);
                units.SetFormatOptions(UnitType.UT_HVAC_Friction, friction);

                //Power
                FormatOptions power = new FormatOptions(DisplayUnitType.DUT_WATTS, 1);
                units.SetFormatOptions(UnitType.UT_HVAC_Power, power);

                //Power Density
                FormatOptions powerDensity = new FormatOptions(DisplayUnitType.DUT_WATTS_PER_SQUARE_METER, 0.01);
                units.SetFormatOptions(UnitType.UT_HVAC_Power_Density, powerDensity);

                //Pressure
                FormatOptions pressure = new FormatOptions(DisplayUnitType.DUT_PASCALS, 0.1);
                units.SetFormatOptions(UnitType.UT_HVAC_Pressure, pressure);

                //Temperature
                FormatOptions temperature = new FormatOptions(DisplayUnitType.DUT_CELSIUS, 0.1);
                units.SetFormatOptions(UnitType.UT_HVAC_Temperature, temperature);

                //Velocity
                FormatOptions hvacVelocity = new FormatOptions(DisplayUnitType.DUT_METERS_PER_SECOND, 0.1);
                units.SetFormatOptions(UnitType.UT_HVAC_Velocity, hvacVelocity);

                //Air flow
                FormatOptions airFlow = new FormatOptions(DisplayUnitType.DUT_LITERS_PER_SECOND, 0.1);
                units.SetFormatOptions(UnitType.UT_HVAC_Airflow, airFlow);

                //Duct Size
                FormatOptions ductSize = new FormatOptions(DisplayUnitType.DUT_MILLIMETERS, 1);
                units.SetFormatOptions(UnitType.UT_HVAC_DuctSize, ductSize);

                //Cross Section
                FormatOptions crossSection = new FormatOptions(DisplayUnitType.DUT_SQUARE_MILLIMETERS, 1);
                units.SetFormatOptions(UnitType.UT_HVAC_CrossSection, crossSection);

                //Heat Gain
                FormatOptions heatGain = new FormatOptions(DisplayUnitType.DUT_WATTS, 0.1);
                units.SetFormatOptions(UnitType.UT_HVAC_HeatGain, heatGain);

                //Roughness
                FormatOptions roughness = new FormatOptions(DisplayUnitType.DUT_MILLIMETERS, 0.01);
                units.SetFormatOptions(UnitType.UT_HVAC_Roughness, roughness);

                //Dynamic Viscosity
                FormatOptions dynamicViscosity = new FormatOptions(DisplayUnitType.DUT_PASCAL_SECONDS, 0.1);
                units.SetFormatOptions(UnitType.UT_HVAC_Viscosity, dynamicViscosity);

                //Air Flow Density
                FormatOptions airFlowDensity = new FormatOptions(DisplayUnitType.DUT_LITERS_PER_SECOND_SQUARE_METER, 0.01);
                units.SetFormatOptions(UnitType.UT_HVAC_Airflow_Density, airFlowDensity);

                //Cooling Load
                FormatOptions coolingLoad = new FormatOptions(DisplayUnitType.DUT_WATTS, 1);
                units.SetFormatOptions(UnitType.UT_HVAC_Cooling_Load, coolingLoad);

                //Heating Load
                FormatOptions heatingLoad = new FormatOptions(DisplayUnitType.DUT_WATTS, 1);
                units.SetFormatOptions(UnitType.UT_HVAC_Heating_Load, heatingLoad);

                //Cooling Load divided by Area
                FormatOptions coolingDividedByArea = new FormatOptions(DisplayUnitType.DUT_WATTS_PER_SQUARE_METER, 0.01);
                units.SetFormatOptions(UnitType.UT_HVAC_Cooling_Load_Divided_By_Area, coolingDividedByArea);

                //Heating Load divided by Area
                FormatOptions heatingDividedByArea = new FormatOptions(DisplayUnitType.DUT_WATTS_PER_SQUARE_METER, 0.01);
                units.SetFormatOptions(UnitType.UT_HVAC_Heating_Load_Divided_By_Area, heatingDividedByArea);

                //Cooling Load divided by Volume
                FormatOptions coolingDevidedByVolume = new FormatOptions(DisplayUnitType.DUT_WATTS_PER_CUBIC_METER, 0.01);
                units.SetFormatOptions(UnitType.UT_HVAC_Cooling_Load_Divided_By_Volume, coolingDevidedByVolume);

                //Heating Load divided by Volume
                FormatOptions HeatingDividedByVolume = new FormatOptions(DisplayUnitType.DUT_WATTS_PER_CUBIC_METER, 0.01);
                units.SetFormatOptions(UnitType.UT_HVAC_Heating_Load_Divided_By_Volume, HeatingDividedByVolume);

                //Air Flow divided by Volume
                FormatOptions airFlowByVolume = new FormatOptions(DisplayUnitType.DUT_LITERS_PER_SECOND_CUBIC_METER, 0.01);
                units.SetFormatOptions(UnitType.UT_HVAC_Airflow_Divided_By_Volume, airFlowByVolume);

                //Air Flow divided by Cooling Load
                FormatOptions airFlowbyCoolingLoad = new FormatOptions(DisplayUnitType.DUT_LITERS_PER_SECOND_KILOWATTS, 0.01);
                units.SetFormatOptions(UnitType.UT_HVAC_Airflow_Divided_By_Cooling_Load, airFlowbyCoolingLoad);

                //Area divided by Cooling Load
                FormatOptions areaByCoolingLoad = new FormatOptions(DisplayUnitType.DUT_SQUARE_METERS_PER_KILOWATTS, 0.01);
                units.SetFormatOptions(UnitType.UT_HVAC_Area_Divided_By_Cooling_Load, areaByCoolingLoad);

                //Area divided by Heating Load
                FormatOptions areaByHeaingLoad = new FormatOptions(DisplayUnitType.DUT_SQUARE_METERS_PER_KILOWATTS, 0.01);
                units.SetFormatOptions(UnitType.UT_HVAC_Area_Divided_By_Heating_Load, areaByHeaingLoad);

                //Slope
                FormatOptions hvacSlope = new FormatOptions(DisplayUnitType.DUT_PERCENTAGE, 0.01);
                units.SetFormatOptions(UnitType.UT_HVAC_Slope, hvacSlope);

                //Factor
                FormatOptions hvacFactor = new FormatOptions(DisplayUnitType.DUT_PERCENTAGE, 0.01);
                units.SetFormatOptions(UnitType.UT_HVAC_Factor, hvacFactor);

                //Duct Insulation Thickness
                FormatOptions DuctInsulationThickness = new FormatOptions(DisplayUnitType.DUT_MILLIMETERS, 1);
                units.SetFormatOptions(UnitType.UT_HVAC_DuctInsulationThickness, DuctInsulationThickness);

                //Duct Lining Thicknesss
                FormatOptions ductLiningThickness = new FormatOptions(DisplayUnitType.DUT_MILLIMETERS, 1);
                units.SetFormatOptions(UnitType.UT_HVAC_DuctLiningThickness, ductLiningThickness);

                //Current
                FormatOptions current = new FormatOptions(DisplayUnitType.DUT_AMPERES, 1);
                units.SetFormatOptions(UnitType.UT_Electrical_Current, current);

                //Eletric Potential
                FormatOptions electricPotential  = new FormatOptions(DisplayUnitType.DUT_VOLTS, 1);
                units.SetFormatOptions(UnitType.UT_Electrical_Potential, electricPotential);

                //Frequency
                FormatOptions elecFrequency = new FormatOptions(DisplayUnitType.DUT_HERTZ, 1);
                units.SetFormatOptions(UnitType.UT_Electrical_Frequency, elecFrequency);

                //Illuminance
                FormatOptions illuminance = new FormatOptions(DisplayUnitType.DUT_LUX, 1);
                units.SetFormatOptions(UnitType.UT_Electrical_Illuminance, illuminance);

                //Luminance
                FormatOptions luminance = new FormatOptions(DisplayUnitType.DUT_CANDELAS_PER_SQUARE_METER, 1);
                units.SetFormatOptions(UnitType.UT_Electrical_Luminance, luminance);

                //Luminous Flux
                FormatOptions luminousFlux = new FormatOptions(DisplayUnitType.DUT_LUMENS, 1);
                units.SetFormatOptions(UnitType.UT_Electrical_Luminous_Flux, luminousFlux);

                //Luminous Intensity
                FormatOptions luminousIntensity = new FormatOptions(DisplayUnitType.DUT_CANDELAS, 1);
                units.SetFormatOptions(UnitType.UT_Electrical_Luminous_Intensity, luminousIntensity);

                //Efficacy
                FormatOptions efficacy = new FormatOptions(DisplayUnitType.DUT_LUMENS_PER_WATT, 1);
                units.SetFormatOptions(UnitType.UT_Electrical_Efficacy, efficacy);

                //Power
                FormatOptions elecPower = new FormatOptions(DisplayUnitType.DUT_WATTS, 1);
                units.SetFormatOptions(UnitType.UT_Electrical_Power, elecPower);

                //Apparent Power
                FormatOptions apparentPower = new FormatOptions(DisplayUnitType.DUT_VOLT_AMPERES, 1);
                units.SetFormatOptions(UnitType.UT_Electrical_Apparent_Power, apparentPower);

                //Power Density
                FormatOptions elePowerDensity = new FormatOptions(DisplayUnitType.DUT_WATTS_PER_SQUARE_METER, 0.01);
                units.SetFormatOptions(UnitType.UT_Electrical_Power_Density, elePowerDensity);

                //Electrical Resistivity
                FormatOptions eleResist = new FormatOptions(DisplayUnitType.DUT_OHM_METERS, 1);
                units.SetFormatOptions(UnitType.UT_Electrical_Resistivity, eleResist);

                //Wire Diameter
                FormatOptions wireDia = new FormatOptions(DisplayUnitType.DUT_MILLIMETERS, 1);
                units.SetFormatOptions(UnitType.UT_WireSize, wireDia);

                //Temperature
                FormatOptions eleTemp = new FormatOptions(DisplayUnitType.DUT_CELSIUS, 1);
                units.SetFormatOptions(UnitType.UT_Electrical_Temperature, eleTemp);

                //Cable Tray Size
                FormatOptions cableTraySize = new FormatOptions(DisplayUnitType.DUT_MILLIMETERS, 0.1);
                units.SetFormatOptions(UnitType.UT_Electrical_CableTraySize, cableTraySize);

                //Conduit Size
                FormatOptions conduitSize = new FormatOptions(DisplayUnitType.DUT_MILLIMETERS, 1);
                units.SetFormatOptions(UnitType.UT_Electrical_ConduitSize, conduitSize);

                //Demand Factor
                FormatOptions demandFactor = new FormatOptions(DisplayUnitType.DUT_PERCENTAGE, 0.01);
                units.SetFormatOptions(UnitType.UT_Electrical_Demand_Factor, demandFactor);

                //Density
                FormatOptions pipeDesity = new FormatOptions(DisplayUnitType.DUT_KILOGRAMS_PER_CUBIC_METER, 0.0001);
                units.SetFormatOptions(UnitType.UT_Piping_Density, pipeDesity);

                //Flow
                FormatOptions pipingFlow = new FormatOptions(DisplayUnitType.DUT_LITERS_PER_SECOND, 0.1);
                units.SetFormatOptions(UnitType.UT_Piping_Flow, pipingFlow);

                //Friction
                FormatOptions pipingFriction = new FormatOptions(DisplayUnitType.DUT_PASCALS_PER_METER, 0.01);
                units.SetFormatOptions(UnitType.UT_Piping_Friction, pipingFriction);

                //Pressure
                FormatOptions pipingPressure = new FormatOptions(DisplayUnitType.DUT_PASCALS, 0.1);
                units.SetFormatOptions(UnitType.UT_Piping_Pressure, pipingPressure);

                //Temperature
                FormatOptions pipingTemp = new FormatOptions(DisplayUnitType.DUT_CELSIUS, 1);
                units.SetFormatOptions(UnitType.UT_Piping_Temperature, pipingTemp);

                //Velocity
                FormatOptions pipingVelocity = new FormatOptions(DisplayUnitType.DUT_METERS_PER_SECOND, 0.1);
                units.SetFormatOptions(UnitType.UT_Piping_Velocity, pipingVelocity);

                //Dynamic Viscosity
                FormatOptions pipingViscosity = new FormatOptions(DisplayUnitType.DUT_PASCAL_SECONDS, 0.1);
                units.SetFormatOptions(UnitType.UT_Piping_Viscosity, pipingViscosity);

                //Pipe Size
                FormatOptions pipeSize = new FormatOptions(DisplayUnitType.DUT_MILLIMETERS, 1);
                units.SetFormatOptions(UnitType.UT_PipeSize, pipeSize);

                //Roughness
                FormatOptions pipeRoughness = new FormatOptions(DisplayUnitType.DUT_MILLIMETERS, 0.001);
                units.SetFormatOptions(UnitType.UT_Piping_Roughness, pipeRoughness);

                //Volume
                FormatOptions pipeVolume = new FormatOptions(DisplayUnitType.DUT_LITERS, 1);
                units.SetFormatOptions(UnitType.UT_Piping_Volume, pipeVolume);

                //Slope
                FormatOptions pipeSlope = new FormatOptions(DisplayUnitType.DUT_PERCENTAGE, 0.01);
                units.SetFormatOptions(UnitType.UT_Piping_Slope, pipeSlope);

                //Pipe Insulation Thickness
                FormatOptions pipeInsulationThickness = new FormatOptions(DisplayUnitType.DUT_MILLIMETERS, 0.1);
                units.SetFormatOptions(UnitType.UT_PipeInsulationThickness, pipeInsulationThickness);

                //Pipe Dimension
                FormatOptions pipeDimension = new FormatOptions(DisplayUnitType.DUT_MILLIMETERS, 0.01);
                units.SetFormatOptions(UnitType.UT_Pipe_Dimension, pipeDimension);

                //Mass
                FormatOptions pipingMass = new FormatOptions(DisplayUnitType.DUT_KILOGRAMS_MASS, 0.01);
                units.SetFormatOptions(UnitType.UT_PipeMass, pipingMass);

                //Mass per unit Length
                FormatOptions massPerLength = new FormatOptions(DisplayUnitType.DUT_KILOGRAMS_MASS_PER_METER, 0.01);
                units.SetFormatOptions(UnitType.UT_PipeMassPerUnitLength, massPerLength);

                //Energy
                FormatOptions enEnergy = new FormatOptions(DisplayUnitType.DUT_JOULES, 1);
                units.SetFormatOptions(UnitType.UT_HVAC_Energy, enEnergy);

                //Coeffcient of Heat Transfer
                FormatOptions cofHeatTransfer = new FormatOptions(DisplayUnitType.DUT_WATTS_PER_SQUARE_METER_KELVIN, 0.0001);
                units.SetFormatOptions(UnitType.UT_HVAC_CoefficientOfHeatTransfer, cofHeatTransfer);

                //Thermal Resistance
                FormatOptions thermalResistance = new FormatOptions(DisplayUnitType.DUT_SQUARE_METER_KELVIN_PER_WATT, 0.0001);
                units.SetFormatOptions(UnitType.UT_HVAC_ThermalResistance, thermalResistance);

                //Thermal Mass
                FormatOptions thermalMass = new FormatOptions(DisplayUnitType.DUT_KILOJOULES_PER_KELVIN, 0.01);
                units.SetFormatOptions(UnitType.UT_HVAC_ThermalMass, thermalMass);

                //Thermal Conductivity
                FormatOptions thermalConduct = new FormatOptions(DisplayUnitType.DUT_WATTS_PER_METER_KELVIN, 0.0001);
                units.SetFormatOptions(UnitType.UT_HVAC_ThermalConductivity, thermalConduct);

                //Specific Heat
                FormatOptions specificHeat = new FormatOptions(DisplayUnitType.DUT_JOULES_PER_GRAM_CELSIUS, 0.0001);
                units.SetFormatOptions(UnitType.UT_HVAC_SpecificHeat, specificHeat);

                //Specific Heat of Vaporization
                FormatOptions specHeatOfVaporiz = new FormatOptions(DisplayUnitType.DUT_JOULES_PER_GRAM, 0.0001);
                units.SetFormatOptions(UnitType.UT_HVAC_SpecificHeatOfVaporization, specHeatOfVaporiz);

                //Permeability
                FormatOptions permeability = new FormatOptions(DisplayUnitType.DUT_NANOGRAMS_PER_PASCAL_SECOND_SQUARE_METER, 0.0001);
                units.SetFormatOptions(UnitType.UT_HVAC_Permeability, permeability);

                doc.SetUnits(units);


                transaction.Commit();

                return Result.Succeeded;
            } catch (Exception e)
            {
                message = e.Message;
                return Result.Failed;
            }
        }
    }
}
