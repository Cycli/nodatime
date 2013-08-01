// Copyright 2010 The Noda Time Authors. All rights reserved.
// Use of this source code is governed by the Apache License 2.0,
// as found in the LICENSE.txt file.

using NUnit.Framework;

namespace NodaTime.Test.Calendars
{
    public partial class IsoCalendarSystemTest
    {
        [Test]
        public void PeriodFields_Eras()
        {
            var sut = isoFields.Eras;

            Assert.That(sut.ToString(), Is.EqualTo("Eras"));
            Assert.That(sut.IsSupported, Is.False);
        }

        [Test]
        public void PeriodFields_Centuries()
        {
            var sut = isoFields.Centuries;

            Assert.That(sut.ToString(), Is.EqualTo("Centuries"));
            Assert.That(sut.IsSupported, Is.True);
            Assert.That(sut.IsFixedLength, Is.False);
        }

        [Test]
        public void PeriodFields_Years()
        {
            var sut = isoFields.Years;

            Assert.That(sut.ToString(), Is.EqualTo("Years"));
            Assert.That(sut.IsSupported, Is.True);
            Assert.That(sut.IsFixedLength, Is.False);
        }

        [Test]
        public void PeriodFields_WeekYears()
        {
            var sut = isoFields.WeekYears;

            Assert.That(sut.ToString(), Is.EqualTo("WeekYears"));
            Assert.That(sut.IsSupported, Is.True);
            Assert.That(sut.IsFixedLength, Is.False);
        }

        [Test]
        public void PeriodFields_Months()
        {
            var sut = isoFields.Months;

            Assert.That(sut.ToString(), Is.EqualTo("Months"));
            Assert.That(sut.IsSupported, Is.True);
            Assert.That(sut.IsFixedLength, Is.False);
        }

        [Test]
        public void PeriodFields_Weeks()
        {
            var sut = isoFields.Weeks;

            Assert.That(sut.ToString(), Is.EqualTo("Weeks"));
            Assert.That(sut.IsSupported, Is.True);
            Assert.That(sut.IsFixedLength, Is.True);
        }

        [Test]
        public void PeriodFields_Days()
        {
            var sut = isoFields.Days;

            Assert.That(sut.ToString(), Is.EqualTo("Days"));
            Assert.That(sut.IsSupported, Is.True);
            Assert.That(sut.IsFixedLength, Is.True);
        }

        [Test]
        public void PeriodFields_Hours()
        {
            var sut = isoFields.Hours;

            Assert.That(sut.ToString(), Is.EqualTo("Hours"));
            Assert.That(sut.IsSupported, Is.True);
            Assert.That(sut.IsFixedLength, Is.True);
        }

        [Test]
        public void PeriodFields_Minutes()
        {
            var sut = isoFields.Minutes;

            Assert.That(sut.ToString(), Is.EqualTo("Minutes"));
            Assert.That(sut.IsSupported, Is.True);
            Assert.That(sut.IsFixedLength, Is.True);
        }

        [Test]
        public void PeriodFields_Seconds()
        {
            var sut = isoFields.Seconds;

            Assert.That(sut.ToString(), Is.EqualTo("Seconds"));
            Assert.That(sut.IsSupported, Is.True);
            Assert.That(sut.IsFixedLength, Is.True);
        }

        [Test]
        public void PeriodFields_Milliseconds()
        {
            var sut = isoFields.Milliseconds;

            Assert.That(sut.ToString(), Is.EqualTo("Milliseconds"));
            Assert.That(sut.IsSupported, Is.True);
            Assert.That(sut.IsFixedLength, Is.True);
        }

        [Test]
        public void PeriodFields_Ticks()
        {
            var sut = isoFields.Ticks;

            Assert.That(sut.ToString(), Is.EqualTo("Ticks"));
            Assert.That(sut.IsSupported, Is.True);
            Assert.That(sut.IsFixedLength, Is.True);
        }
    }
}