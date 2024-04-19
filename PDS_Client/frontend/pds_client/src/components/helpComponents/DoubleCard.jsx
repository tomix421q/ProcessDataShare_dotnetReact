/* eslint-disable no-unused-vars */
/* eslint-disable react/prop-types */
import { useEffect, useState } from 'react'
import { Link } from 'react-router-dom'

// eslint-disable-next-line react/prop-types
const DoubleCard = ({ name, connection, downtimeA, downtimeB, collorRibbon, route }) => {
  const [connectionError, setConnectionError] = useState('hidden')
  const [cardCollor_A, setCardCollor_A] = useState('bg-orange-400')
  const [cardCollor_B, setCardCollor_B] = useState('bg-orange-400')

  const [ribbon, setRibbon] = useState(collorRibbon)

  const [loadingData, setLoadingData] = useState(true)
  //state A
  const [inProduction_A, setInProduction_A] = useState(false)
  const [inActiv_A, setInActiv_A] = useState(false)
  //state B
  const [inProduction_B, setInProduction_B] = useState(false)
  const [inActiv_B, setInActiv_B] = useState(false)
  // inactiv times A
  const [hodDowntime_A, setHodDowntime_A] = useState()
  const [minDowntime_A, setMinDowntime_A] = useState()
  // inactiv times B
  const [hodDowntime_B, setHodDowntime_B] = useState()
  const [minDowntime_B, setMinDowntime_B] = useState()

  //A B CARD
  useEffect(() => {
    if (connection && connection.length > 20) {
      setConnectionError('block')
      setLoadingData(false)
    } else {
      setConnectionError('hidden')
      // A
      if (downtimeA == 0) {
        setCardCollor_A('bg-green-500')
        setLoadingData(false)
        setInProduction_A(true)
        setInActiv_A(false)
      } else if (downtimeA > 0) {
        setCardCollor_A('bg-red-600')
        setLoadingData(false)
        setInProduction_A(false)
        setInActiv_A(true)
        var hodDowntime_A = Math.floor(downtimeA / 60)
        var minDowntime_A = downtimeA % 60
        setHodDowntime_A(hodDowntime_A)
        setMinDowntime_A(minDowntime_A)
      } else {
        setCardCollor_A('bg-yellow-500')
        setLoadingData(true)
        setInProduction_A(false)
        setInActiv_A(false)
      }
      // B
      if (downtimeB == 0) {
        setCardCollor_B('bg-green-500')
        setLoadingData(false)
        setInProduction_B(true)
        setInActiv_B(false)
      } else if (downtimeB > 0) {
        setCardCollor_B('bg-red-600')
        setLoadingData(false)
        setInProduction_B(false)
        setInActiv_B(true)
        var hodDowntime_B = Math.floor(downtimeB / 60)
        var minDowntime_B = downtimeB % 60
        setHodDowntime_B(hodDowntime_B)
        setMinDowntime_B(minDowntime_B)
      } else {
        setCardCollor_B('bg-yellow-500')
        setLoadingData(true)
        setInProduction_B(false)
        setInActiv_B(false)
      }
    }
  }, [setInterval(() => {}, 10000)])

  return (
    <Link className='max-sm:snap-center' to={route}>
      {/* Card */}
      <div className='w-[20rem] xl:w-[37.5rem] h-[180px] xl:h-[17.5rem] overflow-hidden border border-black flex flex-col rounded-2xl shadow-lg shadow-black font-semibold hover:shadow-collor1 drop-shadow-sm transition-all duration-200 hover:scale-105 hover:ring-4'>
        {/* NAME MACHINE */}
        <h2 className='mx-auto text-2xl xl:text-5xl uppercase text-primary font-medium w-full text-center border-b border-gray-600 py-2 font-extraFont bg-gray-700'>
          {/* ribbon  */}
          <span className={`absolute w-[6px] xl:w-[12px] h-full left-0 top-0 rounded-br-2xl ${ribbon}`}></span>
          {name}
        </h2>

        <div className={`flex flex-col items-center h-full relative `}>
          {/*  */}
          {/* ERROR CARD  */}
          <div
            className={`absolute w-full h-full bg-gray-800 flex flex-col items-center mx-auto justify-center ${connectionError}`}
          >
            <h2 className='text-red-500 px-4 p-1 uppercase text-xl xl:text-4xl'>Connection Error</h2>
            <br />
            <abbr
              title={connection}
              className='cursor-help bg-red-500 px-4 p-1 uppercase text-sm xl:text-3xl no-underline mb-[40px]'
            >
              Check Error
            </abbr>
          </div>

          <div className='flex w-[100%] h-full'>
            {/* CARD A  */}
            <div className={`${cardCollor_A} flex flex-col border-r-[1px] border-black w-[50%] `}>
              {/* production and inactiv card and loading  */}
              <span className='text-base xl:text-2xl w-full text-center py-2 '>Status A</span>

              {/* INPRODUCTION  */}
              <h2
                className={`bg-black p-1 mt-4 xl:mt-10 text-base xl:text-4xl  tracking-widest w-fit mx-auto  ${
                  inProduction_A ? 'flex' : 'hidden'
                }`}
              >
                InProduction
              </h2>
              {/* INACTIV  */}
              <div
                className={`bg-black px-4 text-md text-center flex flex-col justify-center mt-1 tracking-widest uppercase w-fit mx-auto ${
                  inActiv_A ? 'flex' : 'hidden'
                }`}
              >
                <h2 className='text-gray-400'>
                  <span className={`text-xl xl:text-5xl text-primary ${hodDowntime_A == 0 ? 'hidden' : 'inline-block'}`}>
                    {hodDowntime_A}
                    <span className='text-gray-400 text-base xl:text-3xl'>hod </span>
                  </span>
                  <span className='text-xl text-primary xl:text-5xl'>
                    {minDowntime_A}
                    <span className='text-gray-400 text-base xl:text-3xl'>min</span>
                  </span>
                </h2>
                <h2 className='text-xl xl:text-5xl'>Inactive</h2>
              </div>
            </div>
            {/* CARD B  */}
            <div className={`${cardCollor_B}  flex flex-col border-l-[1px] border-black w-[50%] `}>
              {/* production and inactiv card and loading  */}
              <span className='text-base xl:text-2xl w-full text-center py-2'>Status B</span>
              {/* INPRODUCTION  */}
              <h2
                className={`bg-black p-1 mt-4 xl:mt-10 text-base xl:text-4xl tracking-widest w-fit mx-auto ${
                  inProduction_B ? 'block' : 'hidden'
                }`}
              >
                InProduction
              </h2>
              {/* INACTIV  */}
              <div
                className={`bg-black px-4 text-md text-center flex flex-col justify-center mt-1 tracking-widest uppercase w-fit mx-auto ${
                  inActiv_B ? 'flex' : 'hidden'
                }`}
              >
                <h2 className='text-gray-400 '>
                  <span className={`text-xl xl:text-5xl text-primary ${hodDowntime_B == 0 ? 'hidden' : 'inline-block'}`}>
                    {hodDowntime_B}
                    <span className='text-gray-400 text-base xl:text-3xl'>hod</span>
                  </span>
                  <span className='text-xl text-primary xl:text-5xl'>
                    {''}
                    {minDowntime_B}
                    <span className='text-gray-400 text-base xl:text-3xl'>min</span>
                  </span>
                </h2>
                <h2 className='text-xl xl:text-5xl'>Inactive</h2>
              </div>
            </div>
          </div>
          {/*  */}
          {/* LOADING  */}
          <div
            className={`bg-black absolute top-[22%] flex p-1 py-2 px-4 items-center justify-center ${
              loadingData ? 'block' : 'hidden'
            } `}
          >
            <h2 className='text-xl  xl:text-4xl tracking-widest uppercase'>
              Trying to <br /> connect...
            </h2>
            <img src='/loading.svg' alt='loading' className='size-10 ml-4' />
          </div>
        </div>
      </div>
    </Link>
  )
}
export default DoubleCard
