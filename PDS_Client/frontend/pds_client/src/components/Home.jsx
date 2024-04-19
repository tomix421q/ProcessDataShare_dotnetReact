import { Link } from 'react-router-dom'

const Home = () => {
  return (
    <div className='section mx-6 lg:mx-32'>
      <div className='flex flex-col lg:flex-row gap-x-28 gap-y-9 max-w-[1500px] w-full mx-auto justify-center'>
        <div className='flex flex-col gap-y-9 w-full items-center'>
          <Link
            to='/dashboardall'
            className='w-full max-w-[700px] h-[300px] rounded-2xl shadow-lg shadow-black uppercase p-5 hover:shadow-collor1 drop-shadow-sm transition-all duration-200 hover:scale-105 hover:ring-4 ring-inset bg-secondary/90 overflow-hidden'
          >
            <div className='flex flex-col group'>
              <h1 className='h2 text-primary relative'>Home dashboard</h1>
              <img
                src='/homeIcons/dashboard.png'
                alt='dashboard'
                className='max-h-[250px] h-auto  w-[70%] mix-blend-overlay group-hover:mix-blend-multiply'
              />
            </div>
          </Link>
          <Link
            to='/database'
            className='w-full max-w-[700px] h-[300px] rounded-2xl shadow-lg shadow-black uppercase p-5 hover:shadow-collor1 drop-shadow-sm transition-all duration-200 hover:scale-105 hover:ring-4 ring-inset bg-secondary/70 overflow-hidden'
          >
            <div className='flex flex-col group'>
              <h1 className=' h2 text-white relative'>Database</h1>

              <img
                src='/homeIcons/database.png'
                alt='dashboard'
                className='max-h-[250px] h-auto  w-[70%] mix-blend-overlay group-hover:mix-blend-multiply '
              />
            </div>
          </Link>
        </div>
        <div className='flex flex-col gap-y-9 w-full items-center'>
          <Link
            to='/Machinesinfo'
            className='w-full max-w-[700px] h-[300px] rounded-2xl shadow-lg shadow-black uppercase p-5 hover:shadow-collor1 drop-shadow-sm transition-all duration-200 hover:scale-105 hover:ring-4 ring-inset bg-secondary/50 overflow-hidden'
          >
            <div className='flex flex-col group'>
              <h1 className=' h2 text-white relative'>Info Machines</h1>

              <img
                src='/homeIcons/production.png'
                alt='dashboard'
                className='max-h-[250px] h-auto  w-[70%] mix-blend-overlay group-hover:mix-blend-multiply '
              />
            </div>
          </Link>
          <Link
            to='/Connection'
            className='w-full max-w-[700px] h-[300px] rounded-2xl shadow-lg shadow-black uppercase p-5 hover:shadow-collor1 drop-shadow-sm transition-all duration-200 hover:scale-105 hover:ring-4 ring-inset1 bg-secondary/30 overflow-hidden'
          >
            <div className='flex flex-col group'>
              <h1 className=' h2 text-white relative'>Connection</h1>

              <img
                src='/homeIcons/connection.png'
                alt='dashboard'
                className='max-h-[250px] h-auto  w-[70%] mix-blend-overlay group-hover:mix-blend-multiply '
              />
            </div>
          </Link>
        </div>
      </div>
    </div>
  )
}
export default Home
